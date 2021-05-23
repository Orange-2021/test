namespace WindowsFormsApplication1
{
    partial class XCOM
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button32 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarCountTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarCountRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarBunttonClearCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarWorkStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.GroupBoxSend = new System.Windows.Forms.GroupBox();
            this.TextBoxSend = new System.Windows.Forms.TextBox();
            this.GroupBoxRecieve = new System.Windows.Forms.GroupBox();
            this.TextBoxRecieve = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAutoLine = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CheckBoxHexSend = new System.Windows.Forms.CheckBox();
            this.CheckBoxHexRecieve = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.GroupBoxSend.SuspendLayout();
            this.GroupBoxRecieve.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.statusStrip);
            this.groupBox1.Controls.Add(this.GroupBoxSend);
            this.groupBox1.Controls.Add(this.GroupBoxRecieve);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(568, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 104);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信道";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "0x";
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Location = new System.Drawing.Point(116, 64);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(104, 36);
            this.button12.TabIndex = 65;
            this.button12.Text = "设置信道";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(45, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(9, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 36);
            this.button5.TabIndex = 64;
            this.button5.Text = "查询信道";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "从机";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "主机";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(83, 497);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 25);
            this.textBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 61;
            this.label1.Text = "文件路径：";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.button32);
            this.groupBox6.Controls.Add(this.comboBox5);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.comboBox4);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Location = new System.Drawing.Point(172, 544);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(607, 53);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "通讯";
            // 
            // button32
            // 
            this.button32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button32.Location = new System.Drawing.Point(443, 20);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 14;
            this.button32.Text = "重获串口";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox5.Location = new System.Drawing.Point(362, 21);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(73, 20);
            this.comboBox5.TabIndex = 57;
            this.comboBox5.Text = "115200";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 56;
            this.label16.Text = "串口波特率：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "AP串口";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(48, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "通讯类型";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(526, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "打开";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "串口"});
            this.comboBox4.Location = new System.Drawing.Point(109, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(56, 20);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.BarCountTx,
            this.toolStripStatusLabel3,
            this.BarCountRx,
            this.toolStripStatusLabel6,
            this.BarBunttonClearCount,
            this.BarWorkStatus,
            this.toolStripStatusLabelTimer,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(3, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(794, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 17);
            this.toolStripStatusLabel1.Text = "XXXXXXXXXX科技有限公司";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "发送：";
            // 
            // BarCountTx
            // 
            this.BarCountTx.Name = "BarCountTx";
            this.BarCountTx.Size = new System.Drawing.Size(15, 17);
            this.BarCountTx.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel3.Text = "接收：";
            // 
            // BarCountRx
            // 
            this.BarCountRx.Name = "BarCountRx";
            this.BarCountRx.Size = new System.Drawing.Size(15, 17);
            this.BarCountRx.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel6.Text = "     ";
            // 
            // BarBunttonClearCount
            // 
            this.BarBunttonClearCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BarBunttonClearCount.IsLink = true;
            this.BarBunttonClearCount.Name = "BarBunttonClearCount";
            this.BarBunttonClearCount.Size = new System.Drawing.Size(56, 17);
            this.BarBunttonClearCount.Text = "清空计数";
            this.BarBunttonClearCount.Click += new System.EventHandler(this.BarBunttonClearCount_Click);
            // 
            // BarWorkStatus
            // 
            this.BarWorkStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BarWorkStatus.Name = "BarWorkStatus";
            this.BarWorkStatus.Size = new System.Drawing.Size(315, 17);
            this.BarWorkStatus.Spring = true;
            this.BarWorkStatus.Text = "工作状态";
            this.BarWorkStatus.Visible = false;
            // 
            // toolStripStatusLabelTimer
            // 
            this.toolStripStatusLabelTimer.Name = "toolStripStatusLabelTimer";
            this.toolStripStatusLabelTimer.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // GroupBoxSend
            // 
            this.GroupBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxSend.Controls.Add(this.TextBoxSend);
            this.GroupBoxSend.Location = new System.Drawing.Point(6, 391);
            this.GroupBoxSend.Name = "GroupBoxSend";
            this.GroupBoxSend.Size = new System.Drawing.Size(546, 89);
            this.GroupBoxSend.TabIndex = 11;
            this.GroupBoxSend.TabStop = false;
            this.GroupBoxSend.Text = "发送数据";
            // 
            // TextBoxSend
            // 
            this.TextBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSend.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxSend.Location = new System.Drawing.Point(6, 24);
            this.TextBoxSend.Multiline = true;
            this.TextBoxSend.Name = "TextBoxSend";
            this.TextBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSend.Size = new System.Drawing.Size(540, 59);
            this.TextBoxSend.TabIndex = 0;
            // 
            // GroupBoxRecieve
            // 
            this.GroupBoxRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxRecieve.Controls.Add(this.TextBoxRecieve);
            this.GroupBoxRecieve.Location = new System.Drawing.Point(6, 186);
            this.GroupBoxRecieve.Name = "GroupBoxRecieve";
            this.GroupBoxRecieve.Size = new System.Drawing.Size(550, 200);
            this.GroupBoxRecieve.TabIndex = 6;
            this.GroupBoxRecieve.TabStop = false;
            this.GroupBoxRecieve.Text = "接收数据";
            // 
            // TextBoxRecieve
            // 
            this.TextBoxRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRecieve.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRecieve.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxRecieve.Location = new System.Drawing.Point(6, 17);
            this.TextBoxRecieve.MaxLength = 120400;
            this.TextBoxRecieve.Multiline = true;
            this.TextBoxRecieve.Name = "TextBoxRecieve";
            this.TextBoxRecieve.ReadOnly = true;
            this.TextBoxRecieve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxRecieve.Size = new System.Drawing.Size(540, 177);
            this.TextBoxRecieve.TabIndex = 0;
            this.TextBoxRecieve.TextChanged += new System.EventHandler(this.TextBoxRecieve_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 160);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button28);
            this.groupBox3.Controls.Add(this.button56);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(568, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 163);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(116, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 36);
            this.button6.TabIndex = 69;
            this.button6.Text = "擦除地磁程序";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(9, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(202, 61);
            this.button9.TabIndex = 1;
            this.button9.Text = "刷新在线地磁列表";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button28
            // 
            this.button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button28.ForeColor = System.Drawing.Color.Red;
            this.button28.Location = new System.Drawing.Point(9, 124);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(95, 36);
            this.button28.TabIndex = 68;
            this.button28.Text = "更新参数";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button56
            // 
            this.button56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button56.Location = new System.Drawing.Point(9, 82);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(95, 36);
            this.button56.TabIndex = 2;
            this.button56.Text = "排序";
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(116, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 36);
            this.button4.TabIndex = 62;
            this.button4.Text = "软复位";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkAutoLine);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.CheckBoxHexSend);
            this.groupBox4.Controls.Add(this.CheckBoxHexRecieve);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(568, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 242);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            // 
            // chkAutoLine
            // 
            this.chkAutoLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoLine.AutoSize = true;
            this.chkAutoLine.Location = new System.Drawing.Point(116, 20);
            this.chkAutoLine.Name = "chkAutoLine";
            this.chkAutoLine.Size = new System.Drawing.Size(72, 16);
            this.chkAutoLine.TabIndex = 67;
            this.chkAutoLine.Text = "自动换行";
            this.chkAutoLine.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(9, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "清空接收区";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(116, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 36);
            this.button10.TabIndex = 55;
            this.button10.Text = "保存数据";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(116, 121);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(95, 36);
            this.button11.TabIndex = 56;
            this.button11.Text = "发送数据";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(17, 168);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 16);
            this.checkBox3.TabIndex = 59;
            this.checkBox3.Text = "X-MODE-1K";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(9, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 53;
            this.button2.Text = "清空发送区";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(9, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 51;
            this.button3.Text = "打开文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CheckBoxHexSend
            // 
            this.CheckBoxHexSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxHexSend.AutoSize = true;
            this.CheckBoxHexSend.Location = new System.Drawing.Point(14, 94);
            this.CheckBoxHexSend.Name = "CheckBoxHexSend";
            this.CheckBoxHexSend.Size = new System.Drawing.Size(84, 16);
            this.CheckBoxHexSend.TabIndex = 57;
            this.CheckBoxHexSend.Text = "16进制发送";
            this.CheckBoxHexSend.UseVisualStyleBackColor = true;
            this.CheckBoxHexSend.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBoxHexRecieve
            // 
            this.CheckBoxHexRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxHexRecieve.AutoSize = true;
            this.CheckBoxHexRecieve.Location = new System.Drawing.Point(14, 20);
            this.CheckBoxHexRecieve.Name = "CheckBoxHexRecieve";
            this.CheckBoxHexRecieve.Size = new System.Drawing.Size(84, 16);
            this.CheckBoxHexRecieve.TabIndex = 58;
            this.CheckBoxHexRecieve.Text = "16进制接收";
            this.CheckBoxHexRecieve.UseVisualStyleBackColor = true;
            this.CheckBoxHexRecieve.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(116, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 36);
            this.button7.TabIndex = 52;
            this.button7.Text = "发送文件";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(12, 489);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 47);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // XCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.groupBox1);
            this.Name = "XCOM";
            this.Text = "无线地磁";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.XCOM_Load);
            this.Resize += new System.EventHandler(this.XCOM_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.GroupBoxSend.ResumeLayout(false);
            this.GroupBoxSend.PerformLayout();
            this.GroupBoxRecieve.ResumeLayout(false);
            this.GroupBoxRecieve.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox GroupBoxSend;
        private System.Windows.Forms.TextBox TextBoxSend;
        private System.Windows.Forms.GroupBox GroupBoxRecieve;
        private System.Windows.Forms.TextBox TextBoxRecieve;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel BarCountTx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel BarCountRx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel BarBunttonClearCount;
        internal System.Windows.Forms.ToolStripStatusLabel BarWorkStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox CheckBoxHexRecieve;
        private System.Windows.Forms.CheckBox CheckBoxHexSend;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimer;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

