namespace CheckIn
{
    partial class CheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip_panel = new System.Windows.Forms.MenuStrip();
            this.AthletesCheckIn_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Major = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_English = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuration_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备端口号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commport_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.设备频率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundrate_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.数据设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataregion_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.数据单元ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datalength_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.起始地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataaddress_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.pf_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.power_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.使用地区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqtype_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.pfset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfconfig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subant_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant3_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant4_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antconfig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_CandidateCheckIn = new System.Windows.Forms.Panel();
            this.button_output = new System.Windows.Forms.Button();
            this.groupBox_checkinfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_checkinfo = new System.Windows.Forms.DataGridView();
            this.groupBox_checkin = new System.Windows.Forms.GroupBox();
            this.textBox_EnterOrder = new System.Windows.Forms.TextBox();
            this.textBox_InterviewGroup = new System.Windows.Forms.TextBox();
            this.label_EnterOrder = new System.Windows.Forms.Label();
            this.label_InterviewGroup = new System.Windows.Forms.Label();
            this.textBox_CandidateLabel = new System.Windows.Forms.TextBox();
            this.textBox_CandidatePersonId = new System.Windows.Forms.TextBox();
            this.textBox_CandidateName = new System.Windows.Forms.TextBox();
            this.textBox_CandidateIndex = new System.Windows.Forms.TextBox();
            this.textBox_CandidateId = new System.Windows.Forms.TextBox();
            this.label_CandidateLabel = new System.Windows.Forms.Label();
            this.label_CandidateIndex = new System.Windows.Forms.Label();
            this.label_CandidateName = new System.Windows.Forms.Label();
            this.label_CandidatePersonId = new System.Windows.Forms.Label();
            this.label_CandidateId = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.stopcheck_button = new System.Windows.Forms.Button();
            this.check_timer = new System.Windows.Forms.Timer(this.components);
            this.Candidate_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidate_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterviewGroup_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidate_GlobeOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_panel.SuspendLayout();
            this.panel_CandidateCheckIn.SuspendLayout();
            this.groupBox_checkinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checkinfo)).BeginInit();
            this.groupBox_checkin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_panel
            // 
            this.menuStrip_panel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.menuStrip_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AthletesCheckIn_ToolStripMenuItem,
            this.Configuration_ToolStripMenuItem});
            this.menuStrip_panel.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_panel.Name = "menuStrip_panel";
            this.menuStrip_panel.Size = new System.Drawing.Size(1350, 29);
            this.menuStrip_panel.TabIndex = 0;
            this.menuStrip_panel.Text = "menuStrip1";
            // 
            // AthletesCheckIn_ToolStripMenuItem
            // 
            this.AthletesCheckIn_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Major,
            this.ToolStripMenuItem_English});
            this.AthletesCheckIn_ToolStripMenuItem.Name = "AthletesCheckIn_ToolStripMenuItem";
            this.AthletesCheckIn_ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.AthletesCheckIn_ToolStripMenuItem.Text = "考生抽签";
            // 
            // ToolStripMenuItem_Major
            // 
            this.ToolStripMenuItem_Major.Name = "ToolStripMenuItem_Major";
            this.ToolStripMenuItem_Major.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_Major.Text = "专业面试";
            this.ToolStripMenuItem_Major.Click += new System.EventHandler(this.ToolStripMenuItem_Major_Click);
            // 
            // ToolStripMenuItem_English
            // 
            this.ToolStripMenuItem_English.Name = "ToolStripMenuItem_English";
            this.ToolStripMenuItem_English.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_English.Text = "英语面试";
            this.ToolStripMenuItem_English.Click += new System.EventHandler(this.ToolStripMenuItem_English_Click);
            // 
            // Configuration_ToolStripMenuItem
            // 
            this.Configuration_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接设置ToolStripMenuItem,
            this.数据设置ToolStripMenuItem,
            this.pf_ToolStripMenuItem,
            this.ant_ToolStripMenuItem});
            this.Configuration_ToolStripMenuItem.Name = "Configuration_ToolStripMenuItem";
            this.Configuration_ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.Configuration_ToolStripMenuItem.Text = "设备配置";
            // 
            // 连接设置ToolStripMenuItem
            // 
            this.连接设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect_ToolStripMenuItem,
            this.Disconnect_ToolStripMenuItem,
            this.设备端口号ToolStripMenuItem,
            this.设备频率ToolStripMenuItem});
            this.连接设置ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.连接设置ToolStripMenuItem.Name = "连接设置ToolStripMenuItem";
            this.连接设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.连接设置ToolStripMenuItem.Text = "连接设置";
            // 
            // Connect_ToolStripMenuItem
            // 
            this.Connect_ToolStripMenuItem.Name = "Connect_ToolStripMenuItem";
            this.Connect_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.Connect_ToolStripMenuItem.Text = "连接设备";
            this.Connect_ToolStripMenuItem.Visible = false;
            this.Connect_ToolStripMenuItem.Click += new System.EventHandler(this.Connect_ToolStripMenuItem_Click);
            // 
            // Disconnect_ToolStripMenuItem
            // 
            this.Disconnect_ToolStripMenuItem.Name = "Disconnect_ToolStripMenuItem";
            this.Disconnect_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.Disconnect_ToolStripMenuItem.Text = "断开连接";
            this.Disconnect_ToolStripMenuItem.Visible = false;
            this.Disconnect_ToolStripMenuItem.Click += new System.EventHandler(this.Disconnect_ToolStripMenuItem_Click);
            // 
            // 设备端口号ToolStripMenuItem
            // 
            this.设备端口号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commport_toolStripComboBox});
            this.设备端口号ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备端口号ToolStripMenuItem.Name = "设备端口号ToolStripMenuItem";
            this.设备端口号ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.设备端口号ToolStripMenuItem.Text = "设备端口号";
            // 
            // commport_toolStripComboBox
            // 
            this.commport_toolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commport_toolStripComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.commport_toolStripComboBox.Name = "commport_toolStripComboBox";
            this.commport_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // 设备频率ToolStripMenuItem
            // 
            this.设备频率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boundrate_toolStripComboBox});
            this.设备频率ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备频率ToolStripMenuItem.Name = "设备频率ToolStripMenuItem";
            this.设备频率ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.设备频率ToolStripMenuItem.Text = "设备频率";
            // 
            // boundrate_toolStripComboBox
            // 
            this.boundrate_toolStripComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.boundrate_toolStripComboBox.Name = "boundrate_toolStripComboBox";
            this.boundrate_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 数据设置ToolStripMenuItem
            // 
            this.数据设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据区域ToolStripMenuItem,
            this.数据单元ToolStripMenuItem,
            this.起始地址ToolStripMenuItem});
            this.数据设置ToolStripMenuItem.Name = "数据设置ToolStripMenuItem";
            this.数据设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.数据设置ToolStripMenuItem.Text = "数据设置";
            // 
            // 数据区域ToolStripMenuItem
            // 
            this.数据区域ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataregion_toolStripComboBox});
            this.数据区域ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据区域ToolStripMenuItem.Name = "数据区域ToolStripMenuItem";
            this.数据区域ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.数据区域ToolStripMenuItem.Text = "数据区域";
            // 
            // dataregion_toolStripComboBox
            // 
            this.dataregion_toolStripComboBox.Items.AddRange(new object[] {
            "RESERVE",
            "EPC",
            "TID",
            "USER"});
            this.dataregion_toolStripComboBox.Name = "dataregion_toolStripComboBox";
            this.dataregion_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 数据单元ToolStripMenuItem
            // 
            this.数据单元ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datalength_toolStripComboBox});
            this.数据单元ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据单元ToolStripMenuItem.Name = "数据单元ToolStripMenuItem";
            this.数据单元ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.数据单元ToolStripMenuItem.Text = "读写单元";
            // 
            // datalength_toolStripComboBox
            // 
            this.datalength_toolStripComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.datalength_toolStripComboBox.Name = "datalength_toolStripComboBox";
            this.datalength_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 起始地址ToolStripMenuItem
            // 
            this.起始地址ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataaddress_toolStripComboBox});
            this.起始地址ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.起始地址ToolStripMenuItem.Name = "起始地址ToolStripMenuItem";
            this.起始地址ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.起始地址ToolStripMenuItem.Text = "起始单元";
            this.起始地址ToolStripMenuItem.Visible = false;
            // 
            // dataaddress_toolStripComboBox
            // 
            this.dataaddress_toolStripComboBox.Name = "dataaddress_toolStripComboBox";
            this.dataaddress_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.dataaddress_toolStripComboBox.Visible = false;
            // 
            // pf_ToolStripMenuItem
            // 
            this.pf_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功率ToolStripMenuItem,
            this.使用地区ToolStripMenuItem,
            this.pfset_ToolStripMenuItem,
            this.pfconfig_ToolStripMenuItem});
            this.pf_ToolStripMenuItem.Name = "pf_ToolStripMenuItem";
            this.pf_ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.pf_ToolStripMenuItem.Text = "功率与地区";
            // 
            // 功率ToolStripMenuItem
            // 
            this.功率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.power_toolStripComboBox});
            this.功率ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.功率ToolStripMenuItem.Name = "功率ToolStripMenuItem";
            this.功率ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.功率ToolStripMenuItem.Text = "功率";
            // 
            // power_toolStripComboBox
            // 
            this.power_toolStripComboBox.Name = "power_toolStripComboBox";
            this.power_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 使用地区ToolStripMenuItem
            // 
            this.使用地区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freqtype_toolStripComboBox});
            this.使用地区ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使用地区ToolStripMenuItem.Name = "使用地区ToolStripMenuItem";
            this.使用地区ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.使用地区ToolStripMenuItem.Text = "使用地区";
            // 
            // freqtype_toolStripComboBox
            // 
            this.freqtype_toolStripComboBox.Items.AddRange(new object[] {
            "CHINA",
            "AMERICA",
            "EUROUP",
            "OTHER"});
            this.freqtype_toolStripComboBox.Name = "freqtype_toolStripComboBox";
            this.freqtype_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // pfset_ToolStripMenuItem
            // 
            this.pfset_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pfset_ToolStripMenuItem.Name = "pfset_ToolStripMenuItem";
            this.pfset_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.pfset_ToolStripMenuItem.Text = "保存修改";
            this.pfset_ToolStripMenuItem.Click += new System.EventHandler(this.pfset_ToolStripMenuItem_Click);
            // 
            // pfconfig_ToolStripMenuItem
            // 
            this.pfconfig_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pfconfig_ToolStripMenuItem.Name = "pfconfig_ToolStripMenuItem";
            this.pfconfig_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.pfconfig_ToolStripMenuItem.Text = "刷新参数";
            this.pfconfig_ToolStripMenuItem.Click += new System.EventHandler(this.pfconfig_ToolStripMenuItem_Click);
            // 
            // ant_ToolStripMenuItem
            // 
            this.ant_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subant_ToolStripMenuItem,
            this.antset_ToolStripMenuItem,
            this.antconfig_ToolStripMenuItem});
            this.ant_ToolStripMenuItem.Name = "ant_ToolStripMenuItem";
            this.ant_ToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.ant_ToolStripMenuItem.Text = "天线";
            // 
            // subant_ToolStripMenuItem
            // 
            this.subant_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ant1_ToolStripMenuItem,
            this.ant2_ToolStripMenuItem,
            this.ant3_ToolStripMenuItem,
            this.ant4_ToolStripMenuItem});
            this.subant_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subant_ToolStripMenuItem.Name = "subant_ToolStripMenuItem";
            this.subant_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.subant_ToolStripMenuItem.Text = "子天线";
            // 
            // ant1_ToolStripMenuItem
            // 
            this.ant1_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant1_ToolStripMenuItem.Name = "ant1_ToolStripMenuItem";
            this.ant1_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant1_ToolStripMenuItem.Text = "天线1";
            this.ant1_ToolStripMenuItem.Click += new System.EventHandler(this.ant1_ToolStripMenuItem_Click);
            // 
            // ant2_ToolStripMenuItem
            // 
            this.ant2_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant2_ToolStripMenuItem.Name = "ant2_ToolStripMenuItem";
            this.ant2_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant2_ToolStripMenuItem.Text = "天线2";
            this.ant2_ToolStripMenuItem.Click += new System.EventHandler(this.ant2_ToolStripMenuItem_Click);
            // 
            // ant3_ToolStripMenuItem
            // 
            this.ant3_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant3_ToolStripMenuItem.Name = "ant3_ToolStripMenuItem";
            this.ant3_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant3_ToolStripMenuItem.Text = "天线3";
            this.ant3_ToolStripMenuItem.Click += new System.EventHandler(this.ant3_ToolStripMenuItem_Click);
            // 
            // ant4_ToolStripMenuItem
            // 
            this.ant4_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant4_ToolStripMenuItem.Name = "ant4_ToolStripMenuItem";
            this.ant4_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant4_ToolStripMenuItem.Text = "天线4";
            this.ant4_ToolStripMenuItem.Click += new System.EventHandler(this.ant4_ToolStripMenuItem_Click);
            // 
            // antset_ToolStripMenuItem
            // 
            this.antset_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.antset_ToolStripMenuItem.Name = "antset_ToolStripMenuItem";
            this.antset_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.antset_ToolStripMenuItem.Text = "保存修改";
            this.antset_ToolStripMenuItem.Click += new System.EventHandler(this.antset_ToolStripMenuItem_Click);
            // 
            // antconfig_ToolStripMenuItem
            // 
            this.antconfig_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.antconfig_ToolStripMenuItem.Name = "antconfig_ToolStripMenuItem";
            this.antconfig_ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.antconfig_ToolStripMenuItem.Text = "刷新参数";
            this.antconfig_ToolStripMenuItem.Click += new System.EventHandler(this.antconfig_ToolStripMenuItem_Click);
            // 
            // panel_CandidateCheckIn
            // 
            this.panel_CandidateCheckIn.Controls.Add(this.button_output);
            this.panel_CandidateCheckIn.Controls.Add(this.groupBox_checkinfo);
            this.panel_CandidateCheckIn.Controls.Add(this.groupBox_checkin);
            this.panel_CandidateCheckIn.Controls.Add(this.check_button);
            this.panel_CandidateCheckIn.Controls.Add(this.stopcheck_button);
            this.panel_CandidateCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CandidateCheckIn.Location = new System.Drawing.Point(0, 29);
            this.panel_CandidateCheckIn.Name = "panel_CandidateCheckIn";
            this.panel_CandidateCheckIn.Size = new System.Drawing.Size(1350, 700);
            this.panel_CandidateCheckIn.TabIndex = 1;
            // 
            // button_output
            // 
            this.button_output.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.button_output.Location = new System.Drawing.Point(1216, 61);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(108, 49);
            this.button_output.TabIndex = 6;
            this.button_output.Text = "导出";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // groupBox_checkinfo
            // 
            this.groupBox_checkinfo.Controls.Add(this.dataGridView_checkinfo);
            this.groupBox_checkinfo.Location = new System.Drawing.Point(464, 36);
            this.groupBox_checkinfo.Name = "groupBox_checkinfo";
            this.groupBox_checkinfo.Size = new System.Drawing.Size(728, 630);
            this.groupBox_checkinfo.TabIndex = 5;
            this.groupBox_checkinfo.TabStop = false;
            this.groupBox_checkinfo.Text = "抽签信息";
            // 
            // dataGridView_checkinfo
            // 
            this.dataGridView_checkinfo.AllowUserToAddRows = false;
            this.dataGridView_checkinfo.AllowUserToDeleteRows = false;
            this.dataGridView_checkinfo.AllowUserToOrderColumns = true;
            this.dataGridView_checkinfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_checkinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_checkinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Candidate_Id,
            this.Candidate_Name,
            this.Label_Name,
            this.InterviewGroup_Id,
            this.Candidate_GlobeOrder});
            this.dataGridView_checkinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_checkinfo.Location = new System.Drawing.Point(3, 25);
            this.dataGridView_checkinfo.Name = "dataGridView_checkinfo";
            this.dataGridView_checkinfo.Size = new System.Drawing.Size(722, 602);
            this.dataGridView_checkinfo.TabIndex = 0;
            this.dataGridView_checkinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_checkinfo_CellFormatting);
            // 
            // groupBox_checkin
            // 
            this.groupBox_checkin.Controls.Add(this.textBox_EnterOrder);
            this.groupBox_checkin.Controls.Add(this.textBox_InterviewGroup);
            this.groupBox_checkin.Controls.Add(this.label_EnterOrder);
            this.groupBox_checkin.Controls.Add(this.label_InterviewGroup);
            this.groupBox_checkin.Controls.Add(this.textBox_CandidateLabel);
            this.groupBox_checkin.Controls.Add(this.textBox_CandidatePersonId);
            this.groupBox_checkin.Controls.Add(this.textBox_CandidateName);
            this.groupBox_checkin.Controls.Add(this.textBox_CandidateIndex);
            this.groupBox_checkin.Controls.Add(this.textBox_CandidateId);
            this.groupBox_checkin.Controls.Add(this.label_CandidateLabel);
            this.groupBox_checkin.Controls.Add(this.label_CandidateIndex);
            this.groupBox_checkin.Controls.Add(this.label_CandidateName);
            this.groupBox_checkin.Controls.Add(this.label_CandidatePersonId);
            this.groupBox_checkin.Controls.Add(this.label_CandidateId);
            this.groupBox_checkin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_checkin.Location = new System.Drawing.Point(28, 27);
            this.groupBox_checkin.Name = "groupBox_checkin";
            this.groupBox_checkin.Size = new System.Drawing.Size(418, 588);
            this.groupBox_checkin.TabIndex = 3;
            this.groupBox_checkin.TabStop = false;
            this.groupBox_checkin.Text = "考生信息";
            // 
            // textBox_EnterOrder
            // 
            this.textBox_EnterOrder.Location = new System.Drawing.Point(149, 456);
            this.textBox_EnterOrder.Name = "textBox_EnterOrder";
            this.textBox_EnterOrder.Size = new System.Drawing.Size(250, 35);
            this.textBox_EnterOrder.TabIndex = 19;
            // 
            // textBox_InterviewGroup
            // 
            this.textBox_InterviewGroup.Location = new System.Drawing.Point(150, 391);
            this.textBox_InterviewGroup.Name = "textBox_InterviewGroup";
            this.textBox_InterviewGroup.Size = new System.Drawing.Size(249, 35);
            this.textBox_InterviewGroup.TabIndex = 18;
            // 
            // label_EnterOrder
            // 
            this.label_EnterOrder.AutoSize = true;
            this.label_EnterOrder.Location = new System.Drawing.Point(27, 456);
            this.label_EnterOrder.Name = "label_EnterOrder";
            this.label_EnterOrder.Size = new System.Drawing.Size(117, 28);
            this.label_EnterOrder.TabIndex = 17;
            this.label_EnterOrder.Text = "面试顺序：";
            // 
            // label_InterviewGroup
            // 
            this.label_InterviewGroup.AutoSize = true;
            this.label_InterviewGroup.Location = new System.Drawing.Point(27, 391);
            this.label_InterviewGroup.Name = "label_InterviewGroup";
            this.label_InterviewGroup.Size = new System.Drawing.Size(117, 28);
            this.label_InterviewGroup.TabIndex = 16;
            this.label_InterviewGroup.Text = "面试组别：";
            // 
            // textBox_CandidateLabel
            // 
            this.textBox_CandidateLabel.Location = new System.Drawing.Point(149, 321);
            this.textBox_CandidateLabel.Name = "textBox_CandidateLabel";
            this.textBox_CandidateLabel.Size = new System.Drawing.Size(250, 35);
            this.textBox_CandidateLabel.TabIndex = 15;
            // 
            // textBox_CandidatePersonId
            // 
            this.textBox_CandidatePersonId.Location = new System.Drawing.Point(149, 257);
            this.textBox_CandidatePersonId.Name = "textBox_CandidatePersonId";
            this.textBox_CandidatePersonId.Size = new System.Drawing.Size(250, 35);
            this.textBox_CandidatePersonId.TabIndex = 14;
            // 
            // textBox_CandidateName
            // 
            this.textBox_CandidateName.Location = new System.Drawing.Point(150, 190);
            this.textBox_CandidateName.Name = "textBox_CandidateName";
            this.textBox_CandidateName.Size = new System.Drawing.Size(249, 35);
            this.textBox_CandidateName.TabIndex = 13;
            // 
            // textBox_CandidateIndex
            // 
            this.textBox_CandidateIndex.Location = new System.Drawing.Point(150, 120);
            this.textBox_CandidateIndex.Name = "textBox_CandidateIndex";
            this.textBox_CandidateIndex.Size = new System.Drawing.Size(249, 35);
            this.textBox_CandidateIndex.TabIndex = 12;
            // 
            // textBox_CandidateId
            // 
            this.textBox_CandidateId.Location = new System.Drawing.Point(149, 62);
            this.textBox_CandidateId.Name = "textBox_CandidateId";
            this.textBox_CandidateId.Size = new System.Drawing.Size(250, 35);
            this.textBox_CandidateId.TabIndex = 11;
            // 
            // label_CandidateLabel
            // 
            this.label_CandidateLabel.AutoSize = true;
            this.label_CandidateLabel.Location = new System.Drawing.Point(26, 321);
            this.label_CandidateLabel.Name = "label_CandidateLabel";
            this.label_CandidateLabel.Size = new System.Drawing.Size(117, 28);
            this.label_CandidateLabel.TabIndex = 10;
            this.label_CandidateLabel.Text = "考生类别：";
            // 
            // label_CandidateIndex
            // 
            this.label_CandidateIndex.AutoSize = true;
            this.label_CandidateIndex.Location = new System.Drawing.Point(26, 123);
            this.label_CandidateIndex.Name = "label_CandidateIndex";
            this.label_CandidateIndex.Size = new System.Drawing.Size(117, 28);
            this.label_CandidateIndex.TabIndex = 7;
            this.label_CandidateIndex.Text = "考生编号：";
            // 
            // label_CandidateName
            // 
            this.label_CandidateName.AutoSize = true;
            this.label_CandidateName.Location = new System.Drawing.Point(26, 193);
            this.label_CandidateName.Name = "label_CandidateName";
            this.label_CandidateName.Size = new System.Drawing.Size(117, 28);
            this.label_CandidateName.TabIndex = 8;
            this.label_CandidateName.Text = "考生姓名：";
            // 
            // label_CandidatePersonId
            // 
            this.label_CandidatePersonId.AutoSize = true;
            this.label_CandidatePersonId.Location = new System.Drawing.Point(5, 260);
            this.label_CandidatePersonId.Name = "label_CandidatePersonId";
            this.label_CandidatePersonId.Size = new System.Drawing.Size(138, 28);
            this.label_CandidatePersonId.TabIndex = 9;
            this.label_CandidatePersonId.Text = "考生身份证：";
            // 
            // label_CandidateId
            // 
            this.label_CandidateId.AutoSize = true;
            this.label_CandidateId.Location = new System.Drawing.Point(26, 65);
            this.label_CandidateId.Name = "label_CandidateId";
            this.label_CandidateId.Size = new System.Drawing.Size(117, 28);
            this.label_CandidateId.TabIndex = 6;
            this.label_CandidateId.Text = "考生序号：";
            // 
            // check_button
            // 
            this.check_button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_button.Location = new System.Drawing.Point(28, 621);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(194, 45);
            this.check_button.TabIndex = 4;
            this.check_button.Text = "开始抽签";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // stopcheck_button
            // 
            this.stopcheck_button.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopcheck_button.Location = new System.Drawing.Point(252, 621);
            this.stopcheck_button.Name = "stopcheck_button";
            this.stopcheck_button.Size = new System.Drawing.Size(194, 45);
            this.stopcheck_button.TabIndex = 5;
            this.stopcheck_button.Text = "停止抽签";
            this.stopcheck_button.UseVisualStyleBackColor = true;
            this.stopcheck_button.Click += new System.EventHandler(this.stopcheck_button_Click);
            // 
            // check_timer
            // 
            this.check_timer.Tick += new System.EventHandler(this.check_timer_Tick);
            // 
            // Candidate_Id
            // 
            this.Candidate_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Candidate_Id.DataPropertyName = "Candidate_Id";
            this.Candidate_Id.HeaderText = "序号";
            this.Candidate_Id.Name = "Candidate_Id";
            this.Candidate_Id.Width = 67;
            // 
            // Candidate_Name
            // 
            this.Candidate_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Candidate_Name.DataPropertyName = "Candidate_Name";
            this.Candidate_Name.HeaderText = "姓名";
            this.Candidate_Name.Name = "Candidate_Name";
            this.Candidate_Name.Width = 67;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Label_Name.DataPropertyName = "Label_Name";
            this.Label_Name.HeaderText = "类别";
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Width = 67;
            // 
            // InterviewGroup_Id
            // 
            this.InterviewGroup_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InterviewGroup_Id.DataPropertyName = "InterviewGroup_Id";
            this.InterviewGroup_Id.HeaderText = "面试组别";
            this.InterviewGroup_Id.Name = "InterviewGroup_Id";
            // 
            // Candidate_GlobeOrder
            // 
            this.Candidate_GlobeOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Candidate_GlobeOrder.DataPropertyName = "Candidate_GlobeOrder";
            this.Candidate_GlobeOrder.HeaderText = "全局顺序";
            this.Candidate_GlobeOrder.Name = "Candidate_GlobeOrder";
            this.Candidate_GlobeOrder.Width = 99;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_CandidateCheckIn);
            this.Controls.Add(this.menuStrip_panel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_panel;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CheckIn";
            this.Text = "MPACC-Reexamination-T2018";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.menuStrip_panel.ResumeLayout(false);
            this.menuStrip_panel.PerformLayout();
            this.panel_CandidateCheckIn.ResumeLayout(false);
            this.groupBox_checkinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checkinfo)).EndInit();
            this.groupBox_checkin.ResumeLayout(false);
            this.groupBox_checkin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_panel;
        private System.Windows.Forms.ToolStripMenuItem AthletesCheckIn_ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_CandidateCheckIn;
        private System.Windows.Forms.GroupBox groupBox_checkin;
        private System.Windows.Forms.GroupBox groupBox_checkinfo;
        private System.Windows.Forms.DataGridView dataGridView_checkinfo;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button stopcheck_button;
        private System.Windows.Forms.Timer check_timer;
        private System.Windows.Forms.ToolStripMenuItem Configuration_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connect_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Disconnect_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备端口号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox commport_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 设备频率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox boundrate_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 数据设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dataregion_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 数据单元ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox datalength_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 起始地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dataaddress_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem pf_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox power_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 使用地区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox freqtype_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem pfset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pfconfig_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subant_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant2_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant3_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant4_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antconfig_ToolStripMenuItem;
        private System.Windows.Forms.Label label_CandidateId;
        private System.Windows.Forms.Label label_CandidateLabel;
        private System.Windows.Forms.Label label_CandidatePersonId;
        private System.Windows.Forms.Label label_CandidateName;
        private System.Windows.Forms.Label label_CandidateIndex;
        private System.Windows.Forms.TextBox textBox_CandidateLabel;
        private System.Windows.Forms.TextBox textBox_CandidatePersonId;
        private System.Windows.Forms.TextBox textBox_CandidateName;
        private System.Windows.Forms.TextBox textBox_CandidateIndex;
        private System.Windows.Forms.TextBox textBox_CandidateId;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Major;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_English;
        private System.Windows.Forms.TextBox textBox_EnterOrder;
        private System.Windows.Forms.TextBox textBox_InterviewGroup;
        private System.Windows.Forms.Label label_EnterOrder;
        private System.Windows.Forms.Label label_InterviewGroup;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterviewGroup_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate_GlobeOrder;
    }
}

