namespace vs_sln {
  partial class main {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btn_connect = new System.Windows.Forms.Button();
      this.cmb_devType = new System.Windows.Forms.ComboBox();
      this.label14 = new System.Windows.Forms.Label();
      this.cmb_chn = new System.Windows.Forms.ComboBox();
      this.cmb_devIndex = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btn_startCAN = new System.Windows.Forms.Button();
      this.textBox_Time1 = new System.Windows.Forms.TextBox();
      this.textBox_AccMask = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cmb_Mode = new System.Windows.Forms.ComboBox();
      this.cmb_Filter = new System.Windows.Forms.ComboBox();
      this.textBox_Time0 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox_AccCode = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.cmb_remote = new System.Windows.Forms.ComboBox();
      this.cmb_extern = new System.Windows.Forms.ComboBox();
      this.btn_send = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.textBox_Data = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.textBox_ID = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.btn_clr = new System.Windows.Forms.Button();
      this.btn_baudHelp = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.txt_TCID_1 = new System.Windows.Forms.TextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.btn_err = new System.Windows.Forms.Button();
      this.txt_GPID_2 = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.txt_TCID_2 = new System.Windows.Forms.TextBox();
      this.label18 = new System.Windows.Forms.Label();
      this.txt_GPID_1 = new System.Windows.Forms.TextBox();
      this.timer_recv = new System.Windows.Forms.Timer(this.components);
      this.textBox_recv = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_connect);
      this.groupBox1.Controls.Add(this.cmb_devType);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.cmb_chn);
      this.groupBox1.Controls.Add(this.cmb_devIndex);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(480, 54);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // btn_connect
      // 
      this.btn_connect.Location = new System.Drawing.Point(407, 21);
      this.btn_connect.Name = "btn_connect";
      this.btn_connect.Size = new System.Drawing.Size(58, 23);
      this.btn_connect.TabIndex = 0;
      this.btn_connect.Text = "连接";
      this.btn_connect.UseVisualStyleBackColor = true;
      this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
      // 
      // cmb_devType
      // 
      this.cmb_devType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_devType.FormattingEnabled = true;
      this.cmb_devType.Items.AddRange(new object[] {
            "DEV_USBCAN",
            "DEV_USBCAN2"});
      this.cmb_devType.Location = new System.Drawing.Point(47, 21);
      this.cmb_devType.MaxDropDownItems = 15;
      this.cmb_devType.Name = "cmb_devType";
      this.cmb_devType.Size = new System.Drawing.Size(91, 20);
      this.cmb_devType.TabIndex = 1;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(10, 25);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(35, 12);
      this.label14.TabIndex = 4;
      this.label14.Text = "类型:";
      // 
      // cmb_chn
      // 
      this.cmb_chn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_chn.FormattingEnabled = true;
      this.cmb_chn.Items.AddRange(new object[] {
            "1",
            "2"});
      this.cmb_chn.Location = new System.Drawing.Point(318, 21);
      this.cmb_chn.Name = "cmb_chn";
      this.cmb_chn.Size = new System.Drawing.Size(47, 20);
      this.cmb_chn.TabIndex = 3;
      // 
      // cmb_devIndex
      // 
      this.cmb_devIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_devIndex.FormattingEnabled = true;
      this.cmb_devIndex.Items.AddRange(new object[] {
            "0"});
      this.cmb_devIndex.Location = new System.Drawing.Point(196, 21);
      this.cmb_devIndex.Name = "cmb_devIndex";
      this.cmb_devIndex.Size = new System.Drawing.Size(41, 20);
      this.cmb_devIndex.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(250, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "第几路CAN:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(148, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "索引号:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btn_startCAN);
      this.groupBox2.Controls.Add(this.textBox_Time1);
      this.groupBox2.Controls.Add(this.textBox_AccMask);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.cmb_Mode);
      this.groupBox2.Controls.Add(this.cmb_Filter);
      this.groupBox2.Controls.Add(this.textBox_Time0);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.textBox_AccCode);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(0, 53);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(480, 77);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      // 
      // btn_startCAN
      // 
      this.btn_startCAN.Location = new System.Drawing.Point(407, 29);
      this.btn_startCAN.Name = "btn_startCAN";
      this.btn_startCAN.Size = new System.Drawing.Size(58, 23);
      this.btn_startCAN.TabIndex = 0;
      this.btn_startCAN.Text = "启动CAN";
      this.btn_startCAN.UseVisualStyleBackColor = true;
      this.btn_startCAN.Click += new System.EventHandler(this.btn_startCAN_Click);
      // 
      // textBox_Time1
      // 
      this.textBox_Time1.Location = new System.Drawing.Point(196, 46);
      this.textBox_Time1.Name = "textBox_Time1";
      this.textBox_Time1.Size = new System.Drawing.Size(28, 21);
      this.textBox_Time1.TabIndex = 4;
      this.textBox_Time1.Text = "1C";
      this.textBox_Time1.TextChanged += new System.EventHandler(this.textBox_Time1_TextChanged);
      // 
      // textBox_AccMask
      // 
      this.textBox_AccMask.Location = new System.Drawing.Point(66, 46);
      this.textBox_AccMask.Name = "textBox_AccMask";
      this.textBox_AccMask.Size = new System.Drawing.Size(57, 21);
      this.textBox_AccMask.TabIndex = 2;
      this.textBox_AccMask.Text = "FFFFFFFF";
      this.textBox_AccMask.TextChanged += new System.EventHandler(this.textBox_AccMask_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(130, 52);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(65, 12);
      this.label6.TabIndex = 0;
      this.label6.Text = "定时器1:0x";
      // 
      // cmb_Mode
      // 
      this.cmb_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_Mode.FormattingEnabled = true;
      this.cmb_Mode.Items.AddRange(new object[] {
            "正常",
            "只听",
            "自测"});
      this.cmb_Mode.Location = new System.Drawing.Point(292, 48);
      this.cmb_Mode.Name = "cmb_Mode";
      this.cmb_Mode.Size = new System.Drawing.Size(102, 20);
      this.cmb_Mode.TabIndex = 6;
      this.cmb_Mode.SelectedIndexChanged += new System.EventHandler(this.cmb_Mode_SelectedIndexChanged);
      // 
      // cmb_Filter
      // 
      this.cmb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_Filter.FormattingEnabled = true;
      this.cmb_Filter.Items.AddRange(new object[] {
            "接收全部类型",
            "只接收标准帧",
            "只接收扩展帧"});
      this.cmb_Filter.Location = new System.Drawing.Point(292, 21);
      this.cmb_Filter.Name = "cmb_Filter";
      this.cmb_Filter.Size = new System.Drawing.Size(102, 20);
      this.cmb_Filter.TabIndex = 5;
      this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
      // 
      // textBox_Time0
      // 
      this.textBox_Time0.Location = new System.Drawing.Point(196, 19);
      this.textBox_Time0.Name = "textBox_Time0";
      this.textBox_Time0.Size = new System.Drawing.Size(28, 21);
      this.textBox_Time0.TabIndex = 3;
      this.textBox_Time0.Text = "00";
      this.textBox_Time0.TextChanged += new System.EventHandler(this.textBox_Time0_TextChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(254, 52);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(35, 12);
      this.label8.TabIndex = 0;
      this.label8.Text = "模式:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(230, 25);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 12);
      this.label7.TabIndex = 0;
      this.label7.Text = "滤波方式:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 52);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 12);
      this.label5.TabIndex = 0;
      this.label5.Text = "屏蔽码:0x";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(130, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 12);
      this.label4.TabIndex = 0;
      this.label4.Text = "定时器0:0x";
      // 
      // textBox_AccCode
      // 
      this.textBox_AccCode.Location = new System.Drawing.Point(68, 19);
      this.textBox_AccCode.Name = "textBox_AccCode";
      this.textBox_AccCode.Size = new System.Drawing.Size(55, 21);
      this.textBox_AccCode.TabIndex = 1;
      this.textBox_AccCode.Text = "00000000";
      this.textBox_AccCode.TextChanged += new System.EventHandler(this.textBox_AccCode_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 25);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 12);
      this.label3.TabIndex = 0;
      this.label3.Text = "验收码:0x";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.cmb_remote);
      this.groupBox3.Controls.Add(this.cmb_extern);
      this.groupBox3.Controls.Add(this.btn_send);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.label10);
      this.groupBox3.Controls.Add(this.textBox_Data);
      this.groupBox3.Controls.Add(this.label13);
      this.groupBox3.Controls.Add(this.textBox_ID);
      this.groupBox3.Controls.Add(this.label12);
      this.groupBox3.Location = new System.Drawing.Point(0, 131);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(480, 81);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      // 
      // cmb_remote
      // 
      this.cmb_remote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_remote.FormattingEnabled = true;
      this.cmb_remote.Items.AddRange(new object[] {
            "数据帧",
            "远程帧"});
      this.cmb_remote.Location = new System.Drawing.Point(195, 20);
      this.cmb_remote.Name = "cmb_remote";
      this.cmb_remote.Size = new System.Drawing.Size(70, 20);
      this.cmb_remote.TabIndex = 2;
      // 
      // cmb_extern
      // 
      this.cmb_extern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_extern.FormattingEnabled = true;
      this.cmb_extern.Items.AddRange(new object[] {
            "标准帧",
            "扩展帧"});
      this.cmb_extern.Location = new System.Drawing.Point(60, 20);
      this.cmb_extern.Name = "cmb_extern";
      this.cmb_extern.Size = new System.Drawing.Size(70, 20);
      this.cmb_extern.TabIndex = 1;
      // 
      // btn_send
      // 
      this.btn_send.Location = new System.Drawing.Point(407, 33);
      this.btn_send.Name = "btn_send";
      this.btn_send.Size = new System.Drawing.Size(58, 23);
      this.btn_send.TabIndex = 0;
      this.btn_send.Text = "发送";
      this.btn_send.UseVisualStyleBackColor = true;
      this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(147, 23);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(47, 12);
      this.label11.TabIndex = 0;
      this.label11.Text = "帧格式:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(10, 24);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(47, 12);
      this.label10.TabIndex = 0;
      this.label10.Text = "帧类型:";
      // 
      // textBox_Data
      // 
      this.textBox_Data.Location = new System.Drawing.Point(62, 51);
      this.textBox_Data.Name = "textBox_Data";
      this.textBox_Data.Size = new System.Drawing.Size(330, 21);
      this.textBox_Data.TabIndex = 4;
      this.textBox_Data.Text = "00 11 22 33 44 55 66 77";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(10, 55);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(35, 12);
      this.label13.TabIndex = 0;
      this.label13.Text = "数据:";
      // 
      // textBox_ID
      // 
      this.textBox_ID.Location = new System.Drawing.Point(322, 20);
      this.textBox_ID.Name = "textBox_ID";
      this.textBox_ID.Size = new System.Drawing.Size(70, 21);
      this.textBox_ID.TabIndex = 3;
      this.textBox_ID.Text = "123";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(272, 24);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(47, 12);
      this.label12.TabIndex = 0;
      this.label12.Text = "帧ID:0x";
      // 
      // btn_clr
      // 
      this.btn_clr.Location = new System.Drawing.Point(407, 218);
      this.btn_clr.Name = "btn_clr";
      this.btn_clr.Size = new System.Drawing.Size(58, 23);
      this.btn_clr.TabIndex = 3;
      this.btn_clr.Text = "清除";
      this.btn_clr.UseVisualStyleBackColor = true;
      this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
      // 
      // btn_baudHelp
      // 
      this.btn_baudHelp.Location = new System.Drawing.Point(194, 218);
      this.btn_baudHelp.Name = "btn_baudHelp";
      this.btn_baudHelp.Size = new System.Drawing.Size(75, 23);
      this.btn_baudHelp.TabIndex = 4;
      this.btn_baudHelp.Text = "波特率帮助";
      this.btn_baudHelp.UseVisualStyleBackColor = true;
      this.btn_baudHelp.Click += new System.EventHandler(this.btn_baudHelp_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(10, 223);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(65, 12);
      this.label9.TabIndex = 6;
      this.label9.Text = "接收的数据";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(9, 59);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(53, 12);
      this.label15.TabIndex = 6;
      this.label15.Text = "控制器ID";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(168, 59);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(53, 12);
      this.label16.TabIndex = 11;
      this.label16.Text = "综保地址";
      // 
      // txt_TCID_1
      // 
      this.txt_TCID_1.Location = new System.Drawing.Point(78, 55);
      this.txt_TCID_1.Name = "txt_TCID_1";
      this.txt_TCID_1.Size = new System.Drawing.Size(70, 21);
      this.txt_TCID_1.TabIndex = 1;
      this.txt_TCID_1.Text = "05050605";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.btn_err);
      this.groupBox4.Controls.Add(this.txt_GPID_2);
      this.groupBox4.Controls.Add(this.label17);
      this.groupBox4.Controls.Add(this.txt_TCID_2);
      this.groupBox4.Controls.Add(this.label18);
      this.groupBox4.Controls.Add(this.txt_GPID_1);
      this.groupBox4.Controls.Add(this.label15);
      this.groupBox4.Controls.Add(this.txt_TCID_1);
      this.groupBox4.Controls.Add(this.label16);
      this.groupBox4.Location = new System.Drawing.Point(486, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(300, 562);
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      // 
      // btn_err
      // 
      this.btn_err.Location = new System.Drawing.Point(117, 20);
      this.btn_err.Name = "btn_err";
      this.btn_err.Size = new System.Drawing.Size(75, 23);
      this.btn_err.TabIndex = 0;
      this.btn_err.Text = "模拟故障";
      this.btn_err.UseVisualStyleBackColor = true;
      this.btn_err.Click += new System.EventHandler(this.btn_err_Click);
      // 
      // txt_GPID_2
      // 
      this.txt_GPID_2.Location = new System.Drawing.Point(238, 87);
      this.txt_GPID_2.Name = "txt_GPID_2";
      this.txt_GPID_2.Size = new System.Drawing.Size(41, 21);
      this.txt_GPID_2.TabIndex = 4;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(9, 91);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(53, 12);
      this.label17.TabIndex = 13;
      this.label17.Text = "控制器ID";
      // 
      // txt_TCID_2
      // 
      this.txt_TCID_2.Location = new System.Drawing.Point(78, 87);
      this.txt_TCID_2.Name = "txt_TCID_2";
      this.txt_TCID_2.Size = new System.Drawing.Size(70, 21);
      this.txt_TCID_2.TabIndex = 3;
      this.txt_TCID_2.Text = "05050605";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(168, 91);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(53, 12);
      this.label18.TabIndex = 15;
      this.label18.Text = "综保地址";
      // 
      // txt_GPID_1
      // 
      this.txt_GPID_1.Location = new System.Drawing.Point(238, 55);
      this.txt_GPID_1.Name = "txt_GPID_1";
      this.txt_GPID_1.Size = new System.Drawing.Size(41, 21);
      this.txt_GPID_1.TabIndex = 2;
      this.txt_GPID_1.Text = "01";
      // 
      // timer_recv
      // 
      this.timer_recv.Tick += new System.EventHandler(this.timer_recv_Tick);
      // 
      // textBox_recv
      // 
      this.textBox_recv.Location = new System.Drawing.Point(0, 246);
      this.textBox_recv.Multiline = true;
      this.textBox_recv.Name = "textBox_recv";
      this.textBox_recv.Size = new System.Drawing.Size(480, 316);
      this.textBox_recv.TabIndex = 5;
      // 
      // main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 562);
      this.Controls.Add(this.textBox_recv);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.btn_baudHelp);
      this.Controls.Add(this.btn_clr);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Name = "main";
      this.Text = "cq1504_pc_can";
      this.Load += new System.EventHandler(this.main_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cmb_devType;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ComboBox cmb_chn;
    private System.Windows.Forms.ComboBox cmb_devIndex;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox_Time1;
    private System.Windows.Forms.TextBox textBox_AccMask;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmb_Mode;
    private System.Windows.Forms.ComboBox cmb_Filter;
    private System.Windows.Forms.TextBox textBox_Time0;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox_AccCode;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btn_connect;
    private System.Windows.Forms.Button btn_startCAN;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox cmb_remote;
    private System.Windows.Forms.ComboBox cmb_extern;
    private System.Windows.Forms.Button btn_send;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBox_Data;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox textBox_ID;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button btn_clr;
    private System.Windows.Forms.Button btn_baudHelp;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox txt_TCID_1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox txt_GPID_1;
    private System.Windows.Forms.TextBox txt_GPID_2;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.TextBox txt_TCID_2;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Button btn_err;
    private System.Windows.Forms.Timer timer_recv;
    private System.Windows.Forms.TextBox textBox_recv;
  }
}

