using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;                                                       //引入socket命名
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;




namespace WindowsFormsApplication1
{
    public partial class XCOM : Form
    {

        bool Timer1_Run_Flag = false;               //定时器中数据运行++标志位
        bool ComThread_Run_Flag = true;             //解析数据线程运行标志位
        bool HexSendFlag = false;                   //发送16进制标志
        bool HexRecieveFlag = false;                //接收16进制标志

        public const byte SOH = 0x01;               //Xmodem协议起始
        public const byte STX = 0x02;               //Xmodem-1k协议起始
        public const byte EOT = 0x04;               //结束
        public const byte ACK = 0x06;               //正常响应
        public const byte NAK = 0x15;               //非正常响应
        public const byte CAN = 0x18;               //严重错误，结束
        public const byte POLL = 0x43;              //轮询字符C
        public const byte CTRLZ = 0x1A;             //填充字符
        public const byte NONE = 0x00;              //空

        public const int Per_Pack_Sz = 1024;        //每包发送的字节数 1K
        public const int MAX_RSEND = 20;            //最大重发次数
        public int Per_Sec_Count;                   //等待字符C允许时间
        public const int MAX_WAIT_C_SEC = 10;       //等待字符C允许时间

        //byte[] Open_File_array = new byte[40960];   //初始化字节数组40K
        int Open_File_array_length;
        List<byte> Open_File_list = new List<byte>();


        private Thread ComThread;

        private bool ServerSocket_flag = false;
        List<string> list_addr = new List<string>();

        DateTime beforDT;
        DateTime afterDT;

        bool flag_time = false;

        //beforDT = System.DateTime.Now;

        //afterDT = System.DateTime.Now;
        //TimeSpan ts = afterDT.Subtract(beforDT);
        //Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);


        public XCOM()
        {
            InitializeComponent();
            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//关闭跨线程检测
        }

        private void XCOM_Load(object sender, EventArgs e)
        {
            //初始化通讯类型为串口通讯
            this.comboBox4.SelectedIndex = 0;

            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            this.comboBox1.Items.AddRange(ports);
            this.comboBox1.SelectedIndex = this.comboBox1.Items.Count > 0 ? 0 : -1;

            this.serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");// 将打印机的字符集设置为端口的字符集

            this.listView1.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("位置", 65, HorizontalAlignment.Center);
            this.listView1.Columns.Add("类型", 65, HorizontalAlignment.Center);
            this.listView1.Columns.Add("编号", 85, HorizontalAlignment.Center);
            this.listView1.Columns.Add("状态", 85, HorizontalAlignment.Center);
            this.listView1.Columns.Add("车次", 65, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("磁场", 40, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("X轴", 40, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("Y轴", 40, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("Z轴", 40, HorizontalAlignment.Center);
            this.listView1.Columns.Add("状态流水号", 85, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("丢包数", 55, HorizontalAlignment.Center);
            //this.listView1.Columns.Add("信号质量", 65, HorizontalAlignment.Center);
            this.listView1.Columns.Add("电压", 85, HorizontalAlignment.Center);

            BarWorkStatus.Text = "软件就绪";
            BarWorkStatus.Visible = true;
        }

        delegate void SetricrichTextBox1Callback(string str);

        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (chkAutoLine.Checked && TextBoxRecieve.Text.Length > 0)
                {
                    TextBoxRecieve.AppendText("\r\n");
                }
                TextBoxRecieve.AppendText(content);
            }));
        }




        public void AddData(byte[] data, int length)
        {
            

            if (HexRecieveFlag == true)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AddContent(sb.ToString().ToUpper());
            }
            else
            {
                AddContent(new ASCIIEncoding().GetString(data));
            }
        }
        

        //串口接收事件
        private void server()
        {
            byte[] rcv_buffer = new byte[255]; //创建数字缓存区

            while (true)
            {
                
                while (ComThread_Run_Flag)
                {                    
                //loop:
                    for (int j = 0; j < rcv_buffer.Length; j++)
                    {
                        rcv_buffer[j] = 0;
                    }

                    if (this.serialPort1.IsOpen)
                    {
                        try
                        {
                            Thread.Sleep(1);
                            int rcv_DataLen = serialPort1.BytesToRead; //接收的字节数
                            if (rcv_DataLen > 0)
                            {
                                if (rcv_DataLen >= 3)//字节个数大于等于3个
                                {
                                    serialPort1.Read(rcv_buffer, 0, 3);//把数据读入缓存区

                                    if ((rcv_buffer[0] != 0x00 && rcv_buffer[1] != 0xAA && rcv_buffer[2] != 0x0B) && (rcv_buffer[0] != 0xAB && rcv_buffer[1] != 0xBC && rcv_buffer[2] != 0xCD))
                                    {                                        
                                        //Thread.Sleep(1);
                                        rcv_DataLen = serialPort1.BytesToRead; //接收的字节数
                                        if (rcv_DataLen > 0)
                                        {
                                            serialPort1.Read(rcv_buffer, 3, rcv_DataLen);//把数据读入缓存区
                                            rcv_DataLen = rcv_DataLen + 3;
                                        }
                                    }                                    
                                }
                                else//接收到小于3个字符时的处理函数
                                {
                                    serialPort1.Read(rcv_buffer, 0, rcv_DataLen);//把数据读入缓存区
                                }

                                //将收到的数据显示
                                for (int j = 0; j < rcv_DataLen; j++)
                                {
                                    Console.Write(rcv_buffer[j].ToString("X2") + " ");
                                }
                                Console.WriteLine("");

                                this.AddData(rcv_buffer, rcv_DataLen);//输出显示数据
                                BarCountRx.Text = Convert.ToString(Convert.ToInt32(BarCountRx.Text) + rcv_DataLen); //接收字节计数
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    //DateTime afterDT = System.DateTime.Now;
                    //TimeSpan ts = afterDT.Subtract(beforDT);
                    //Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
                }                
            }
        }
        //接收数据框
        private void TextBoxRecieve_TextChanged(object sender, EventArgs e)
        {
            TextBoxRecieve.SelectionStart = TextBoxRecieve.Text.Length;//获取接收的字符数
            TextBoxRecieve.ScrollToCaret(); //将内容滚动到插入的位置
        }
        //接收16进制打钩
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            HexRecieveFlag = CheckBoxHexRecieve.Checked;
        }
        //发送16进制打钩
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HexSendFlag = CheckBoxHexSend.Checked;
        }
        //清空发送区按钮
        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxSend.Text = "";
            //BarCountTx.Text = "0";  //发送清零
        }
        //发送数据按钮
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string outDataBuf = TextBoxSend.Text;//读取发送文本框信息
                if (outDataBuf == "") return;//为空退出
                if (serialPort1.IsOpen == true) //串口打开
                {
                    if (HexSendFlag == true) //如果发送16进制为1
                    {
                        //-----------十六进制发送------------
                        outDataBuf = outDataBuf.Replace(" ", "");    //清除空格
                        outDataBuf = outDataBuf.Replace("\r\n", ""); //清除回车
                        if ((outDataBuf.Length % 2) != 0)
                        {
                            MessageBox.Show("请输入正确的十六进制数，用空格和回车隔开"); //显示异常状况
                            return; //退出
                        }
                        byte[] outBytes = new byte[outDataBuf.Length / 2];     //定义一个数组      
                        for (int I = 0; I < outDataBuf.Length; I += 2)
                        {
                            outBytes[I / 2] = Convert.ToByte(outDataBuf.Substring(I, 2));//提取文本框数据出来
                        }
                        serialPort1.Write(outBytes, 0, outDataBuf.Length / 2);//串口发送数据
                        BarCountTx.Text = Convert.ToString(Convert.ToInt32(BarCountTx.Text) + outDataBuf.Length / 2);//发送字节计数
                    }
                    else //文本发送
                    {
                        serialPort1.Write(outDataBuf);//串口发送数据
                        BarCountTx.Text = Convert.ToString(Convert.ToInt32(BarCountTx.Text) + outDataBuf.Length);//发送字节计数
                    }
                }
                else
                {
                    MessageBox.Show("串口未打开，请先打开串口。"); //显示异常状况
                }
            }
            catch  //错误处理
            {
                MessageBox.Show("数据输入或发送错误！"); //显示异常状况
            }
        }
        //清空接收区
        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxRecieve.Text = "";
        }
        //保存文本框数据
        private void button10_Click(object sender, EventArgs e)
        {
            if (TextBoxRecieve.Text == string.Empty)
            {
                BarWorkStatus.Text = "接收区为空，不保存！";
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "TXT文本|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)//文件创建成功
                {
                    File.AppendAllText(saveFile.FileName, "\r\n******" + DateTime.Now.ToString() + "******\r\n");
                    File.AppendAllText(saveFile.FileName, TextBoxRecieve.Text);
                    BarWorkStatus.Text = "保存成功！";
                }
            }

        }
        //清空底部计数
        private void BarBunttonClearCount_Click(object sender, EventArgs e)
        {
            BarCountRx.Text = "0";  //接收清零
            BarCountTx.Text = "0";  //发送清零
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (0 == this.comboBox4.SelectedIndex)
            {
                //根据当前串口对象，来判断操作
                if (this.serialPort1.IsOpen)
                {
                    //打开时点击，则关闭串口
                    this.serialPort1.Close();

                    if (null != ComThread)
                    {
                        if (ComThread.IsAlive == true)
                        {
                            ComThread.Abort();
                        }
                    }
                    this.serialPort1.Close();
                    BarWorkStatus.Text = "软件就绪";

                    this.ServerSocket_flag = false;
                }
                else
                {
                    if (this.comboBox1.Text == "")
                    {
                        MessageBox.Show("请选择串口！"); //显示异常状况
                        return;
                    }
                    if (this.comboBox5.Text == "")
                    {
                        MessageBox.Show("请选择波特率！"); //显示异常状况
                        return;
                    }
                    //关闭时点击，则设置好端口，波特率后打开
                    this.serialPort1.PortName = this.comboBox1.Text;
                    this.serialPort1.BaudRate = Convert.ToInt32(this.comboBox5.Text);

                    try
                    {
                        this.serialPort1.Open();

                        Control.CheckForIllegalCrossThreadCalls = false;            //解决线程之间互相访问的问题
                        BarWorkStatus.Text = "串口已打开";

                        this.ComThread = new Thread(new ThreadStart(server));
                        this.ComThread.IsBackground = true;
                        this.ComThread.Start();
                        this.ServerSocket_flag = true;
                    }
                    catch (Exception ex)
                    {
                        //现实异常信息给客户。
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            //设置按钮的状态
            this.button8.Text = (this.serialPort1.IsOpen || this.ServerSocket_flag) ? "关闭" : "打开";
            if (this.button8.Text == "关闭")
            {
                comboBox1.Enabled = false;
                comboBox4.Enabled = false;
                button32.Enabled = false;
                comboBox5.Enabled = false;
                timer1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox4.Enabled = true;
                button32.Enabled = true;
                button12.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;
                button28.Enabled = true;
                button7.Enabled = true;
                comboBox5.Enabled = true;
                timer1.Enabled = false;
            }
        }
        //刷新地磁列表
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }
            this.listView1.Items.Clear();
            this.list_addr.Clear();
        }
        //重新获取串口
        private void button32_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            this.comboBox1.Items.AddRange(ports);
            this.comboBox1.SelectedIndex = this.comboBox1.Items.Count > 0 ? 0 : -1;
        }
        //关闭软件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != ComThread)
            {
                if (ComThread.IsAlive == true)
                {
                    ComThread.Abort();
                }
            }
            this.serialPort1.Close();
            Application.Exit();
        }
        //排序
        private void button56_Click(object sender, EventArgs e)
        {

            
        }
        //软复位
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }

            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中检测器", "重启传感器", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (0 == this.comboBox4.SelectedIndex)
            {
                try
                {
                    button4.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //查询信道
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)         //主机或从机都未被选择
            {
                MessageBox.Show("请选择主机或从机", "查询信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //主机被选择
            if (radioButton1.Checked == true)
            {
                byte[] send_buffer = new byte[5];

                send_buffer[0] = 0xab;
                send_buffer[1] = 0xbc;
                send_buffer[2] = 0xcd;
                send_buffer[3] = 0xd1;
                send_buffer[4] = 0x05;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(send_buffer[i].ToString("X2") + " ");
                }

                Console.WriteLine("");

                if (0 == this.comboBox4.SelectedIndex)
                {
                    try
                    {
                        this.serialPort1.Write(send_buffer, 0, 5);
                        BarCountTx.Text = Convert.ToString(Convert.ToInt32(BarCountTx.Text) + 5);//发送字节计数
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

            }
            //从机被选择
            else if (radioButton2.Checked == true)
            {
                if (this.listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择检测器", "查询信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (0 == this.comboBox4.SelectedIndex)
                {
                    try
                    {
                        button5.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }

        }
        //设置信道
        private void button12_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)         //主机或从机都未被选择
            {
                MessageBox.Show("请选择主机或从机", "查询信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (0 == this.textBox2.Text.Length)
            {
                MessageBox.Show("设置值不能为空", "设置信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (0 == this.textBox2)
            //{
            //    MessageBox.Show("设置值不正确", "设置信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //主机被选择
            if (radioButton1.Checked == true)
            {
                byte[] send_buffer = new byte[6];

                send_buffer[0] = 0xab;
                send_buffer[1] = 0xbc;
                send_buffer[2] = 0xcd;
                send_buffer[3] = 0xd2;
                send_buffer[4] = (byte)((Convert.ToUInt16(this.textBox2.Text.ToString(), 16) & 0x00FF));
                send_buffer[5] = 0x00;

                for (int i = 0; i < 5; i++)
                {
                    send_buffer[5] += send_buffer[i];
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.Write(send_buffer[i].ToString("X2") + " ");
                }

                Console.WriteLine("");

                if (0 == this.comboBox4.SelectedIndex)
                {
                    try
                    {
                        this.serialPort1.Write(send_buffer, 0, 6);
                        BarCountTx.Text = Convert.ToString(Convert.ToInt32(BarCountTx.Text) + 6);//发送字节计数
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

            }
            //从机被选择
            else if (radioButton2.Checked == true)
            {
                if (this.listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择检测器", "查询信道", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (0 == this.comboBox4.SelectedIndex)
                {
                    try
                    {
                        button12.Enabled = false;
                        //this.serialPort1.Write(send_buffer, 0, 13);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
        //打开文件
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }

            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //定义打开文本位置的类

            openFileDialog1.Filter = "Bin Files (.bin)|*.bin|所有文件 (*.*)|*.*";//文件筛选器的设定
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                try
                {
                    Open_File_list.Clear();

                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);//初始化文件流

                    BinaryReader sr = new BinaryReader(fs);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);

                    Open_File_array_length = (int)fs.Length;
                    
                    for (int i = 0; i < Open_File_array_length; i++)
                    {
                        byte tmp = sr.ReadByte();
                        Open_File_list.Add(tmp);                        
                    }
                    //关闭此StreamReader对象 
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        //发送文件
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }
            if (this.textBox1.Text == "" && Open_File_array_length == 0)
            {
                MessageBox.Show("未打开文件", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBox3.Checked == true)
            {
                ComThread_Run_Flag = false;
                button7.Enabled = false;
                Timer1_Run_Flag = true;

                byte[] rcv_buffer = new byte[255]; //创建数字缓存区
                byte[] send_buffer = new byte[1029]; //创建缓存区  1024 for XModem 1k + 3 head chars + 2 crc
                byte packetno = 1;
                int complate_sz = 0;        //已经发送的字节数
                int totle_sz = 0;           //需要发送数据包的长度
                int remnant_sz = 0;         //剩余长度
                bool complate = false;      //发送完成标志位
                bool done = true;
                //string return_data = "";    //返回值
                int Send_Times = 0;         //重发次数

                while (done)
                {
                    Thread.Sleep(1);
                    Per_Sec_Count++;
                    if (Per_Sec_Count > MAX_WAIT_C_SEC*500)
                    {
                        done = false;
                        Per_Sec_Count = 0;
                        button7.Enabled = true;
                        ComThread_Run_Flag = true;
                        //Timer1_Run_Flag = false;
                        toolStripProgressBar1.Value = 0;//设置当前值
                        MessageBox.Show("接收超时", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int rcv_DataLen = serialPort1.BytesToRead; //接收的字节数

                    if (rcv_DataLen > 0)
                    {
                        serialPort1.Read(rcv_buffer, 0, rcv_DataLen);//把数据读入缓存区
                        Console.WriteLine("rcv_buffer0:{0}", rcv_buffer[0].ToString("X2") + " ");
                        Console.WriteLine("totle_sz:{0}  complate_sz:{1}   remnant_sz{2}", totle_sz, complate_sz, remnant_sz);
                        this.AddData(rcv_buffer, rcv_DataLen);//输出显示数据
                        BarCountRx.Text = Convert.ToString(Convert.ToInt32(BarCountRx.Text) + rcv_DataLen); //接收字节计数


                        if (rcv_buffer[0] == POLL)
                        {
                            Per_Sec_Count = 0;
                            totle_sz = Open_File_array_length;
                            packetno = 1;
                            complate_sz = 0;
                            Send_Times = 0;
                            toolStripProgressBar1.Maximum = (int)totle_sz;
                            toolStripProgressBar1.Value = 0;//设置当前值
                            goto send_data;
                        }
                        else if (rcv_buffer[0] == ACK)
                        {
                            Per_Sec_Count = 0;
                            complate_sz = complate_sz + remnant_sz;
                            toolStripProgressBar1.Value = complate_sz;
                            if (complate_sz < totle_sz)
                            {
                                Send_Times = 0;
                                packetno++;
                                goto send_data;
                            }
                            else
                            {
                                if (complate == true)
                                {
                                    done = false;
                                    Per_Sec_Count = 0;
                                    button7.Enabled = true;
                                    ComThread_Run_Flag = true;
                                    //Timer1_Run_Flag = false;
                                    toolStripProgressBar1.Value = 0;//设置当前值
                                    MessageBox.Show("发送完成", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    flag_time = true;
                                    beforDT = System.DateTime.Now;

                                    return;
                                }
                                else
                                {
                                    goto send_data;
                                }
                            }
                        }
                        else if (rcv_buffer[0] == NAK)
                        {
                            Per_Sec_Count = 0;
                            goto send_data;
                        }
                        else if (rcv_buffer[0] == CAN)
                        {
                            done = false;
                            Per_Sec_Count = 0;
                            button7.Enabled = true;
                            ComThread_Run_Flag = true;
                            //Timer1_Run_Flag = false;
                            toolStripProgressBar1.Value = 0;//设置当前值
                            MessageBox.Show("强制结束", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            done = false;
                            Per_Sec_Count = 0;
                            button7.Enabled = true;
                            ComThread_Run_Flag = true;
                            //Timer1_Run_Flag = false;
                            toolStripProgressBar1.Value = 0;//设置当前值
                            MessageBox.Show("发送错误", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    send_data:
                        try
                        {
                            if (Send_Times < MAX_RSEND)
                            {
                                send_buffer[0] = STX;
                                send_buffer[1] = packetno;
                                send_buffer[2] = (byte)(~packetno);
                                remnant_sz = totle_sz - complate_sz;
                                if (remnant_sz > Per_Pack_Sz)
                                {
                                    remnant_sz = Per_Pack_Sz;
                                }
                                if (remnant_sz > 0)
                                {
                                    //Array.Copy(Open_File_array, complate_sz, send_buffer, 3, remnant_sz);

                                    Open_File_list.CopyTo(complate_sz, send_buffer, 3, remnant_sz);
                                    if (remnant_sz < Per_Pack_Sz)         //数据不足一包完整的数据包
                                    {
                                        for (int i = 3 + remnant_sz; i < Per_Pack_Sz + 3; i++)
                                        {
                                            send_buffer[i] = CTRLZ;
                                        }
                                    }

                                    int CRC = u16CRCVerify(send_buffer, 3, Per_Pack_Sz);

                                    send_buffer[Per_Pack_Sz + 3] = (byte)((CRC >> 8) & 0xFF);
                                    send_buffer[Per_Pack_Sz + 4] = (byte)((CRC) & 0xFF);

                                    for (int j = 0; j < Per_Pack_Sz + 5; j++)
                                    {
                                        Console.Write(send_buffer[j].ToString("X2") + " ");
                                    }
                                    Console.WriteLine("");

                                    this.serialPort1.Write(send_buffer, 0, Per_Pack_Sz + 5);
                                    Send_Times++;
                                }
                                else
                                {
                                    byte[] buffer2 = new byte[1];
                                    buffer2[0] = EOT;
                                    for (int j = 0; j < 1; j++)
                                    {
                                        Console.Write(buffer2[j].ToString("X2") + " ");
                                    }
                                    Console.WriteLine("");

                                    this.serialPort1.Write(buffer2, 0, 1);

                                    complate = true;
                                }
                            }
                            else
                            {
                                done = false;
                                Send_Times = 0;
                                Per_Sec_Count = 0;
                                button7.Enabled = true;
                                ComThread_Run_Flag = true;
                                //Timer1_Run_Flag = false;
                                toolStripProgressBar1.Value = 0;//设置当前值
                                MessageBox.Show("发送错误", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("暂不支持其他发送模式!", "发送文件", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //擦除地磁程序
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }

            string send_buffer = "IAP";

            for (int i = 0; i < 1; i++)
            {
                Console.Write(send_buffer);
            }

            Console.WriteLine("");

            if (0 == this.comboBox4.SelectedIndex)
            {
                try
                {
                    this.serialPort1.Write(send_buffer);
                    BarCountTx.Text = Convert.ToString(Convert.ToInt32(BarCountTx.Text) + 3);//发送字节计数
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        //更新参数
        private void button28_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "打开")
            {
                return;
            }

            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中检测器", "更新参数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (0 == this.comboBox4.SelectedIndex)
            {
                try
                {
                    button28.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTimer.Text = DateTime.Now.ToString();           //显示当前时间
            //if (Timer1_Run_Flag == true)
            //{
            //    Per_Sec_Count++;
            //}
            //else
            //{
            //    Per_Sec_Count = 0;
            //}
            //MessageBox.Show("每秒加一", "TIMER1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        int u16CRCVerify(byte[] cp, int index, int len)
        {
            int u16CRC = 0;
            for (int i = index; i < len + index; i++)
            {
                u16CRC = u16CRC ^ (cp[i] << 8);
                for (int j = 0; j < 8; j++)
                {
                    if ((u16CRC & 0x8000) != 0)
                    {
                        u16CRC = u16CRC << 1 ^ 0x1021;
                    }
                    else
                    {
                        u16CRC = u16CRC << 1;
                    }
                }
            }
            return u16CRC;
        }

        #region 改变窗体大小是更改控件高度
        private void XCOM_Resize(object sender, EventArgs e)
        {
            //int high = this.Height;
            //groupBox1.Height = high / 4 - 5;
            //groupBox2.Height = high / 4 - 5;
            //groupBox3.Height = high / 4 - 5;
            //groupBox4.Height = high / 4 - 5;
            //groupBox5.Height = high / 4 - 5;
            //groupBox6.Height = high / 4 - 5;
            //GroupBoxRecieve.Height = high / 4 - 5;
            //GroupBoxSend.Height = high / 4 - 5;

            //groupBox2.Top = groupBox3.Top + high / 4 - 5;
            //groupBox4.Top = groupBox2.Top + high / 4 - 5;
            //groupBox6.Top = groupBox4.Top + high / 4 - 5;
            //GroupBoxRecieve.Top = groupBox1.Top + high / 4 - 5;
            //GroupBoxSend.Top = GroupBoxRecieve.Top + high / 4 - 5;
            //groupBox5.Top = GroupBoxSend.Top + high / 4 - 5;

        }
        #endregion
    }
}