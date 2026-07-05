namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    partial class PlcDetailUC
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_DeviceName = new System.Windows.Forms.Label();
            this.lbl_deviceType = new System.Windows.Forms.Label();
            this.lbl_deviceStuate = new System.Windows.Forms.Label();
            this.lbl_deviceID = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_DeviceEnable = new System.Windows.Forms.Button();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.btn_ClearConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_PlcTimeout = new System.Windows.Forms.NumericUpDown();
            this.cbx_PlcBaudRate = new System.Windows.Forms.ComboBox();
            this.lbl_PlcBaudRate = new System.Windows.Forms.Label();
            this.lbl_PlcTimeout = new System.Windows.Forms.Label();
            this.lbl_PlcStationNo = new System.Windows.Forms.Label();
            this.lbl_PlcProtocol = new System.Windows.Forms.Label();
            this.lbl_PlcPort = new System.Windows.Forms.Label();
            this.cbx_PlcProtocol = new System.Windows.Forms.ComboBox();
            this.lbl_PlcIP = new System.Windows.Forms.Label();
            this.nud_PlcStationNo = new System.Windows.Forms.NumericUpDown();
            this.txt_PlcIP = new System.Windows.Forms.TextBox();
            this.nud_Port = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlcTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlcStationNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 712);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.lbl_DeviceName);
            this.flowLayoutPanel1.Controls.Add(this.lbl_deviceType);
            this.flowLayoutPanel1.Controls.Add(this.lbl_deviceStuate);
            this.flowLayoutPanel1.Controls.Add(this.lbl_deviceID);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1123, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_DeviceName
            // 
            this.lbl_DeviceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_DeviceName.AutoSize = true;
            this.lbl_DeviceName.Location = new System.Drawing.Point(3, 0);
            this.lbl_DeviceName.Name = "lbl_DeviceName";
            this.lbl_DeviceName.Size = new System.Drawing.Size(82, 24);
            this.lbl_DeviceName.TabIndex = 0;
            this.lbl_DeviceName.Text = "设备名";
            // 
            // lbl_deviceType
            // 
            this.lbl_deviceType.AutoSize = true;
            this.lbl_deviceType.Location = new System.Drawing.Point(91, 0);
            this.lbl_deviceType.Name = "lbl_deviceType";
            this.lbl_deviceType.Size = new System.Drawing.Size(106, 24);
            this.lbl_deviceType.TabIndex = 2;
            this.lbl_deviceType.Text = "设备类型";
            // 
            // lbl_deviceStuate
            // 
            this.lbl_deviceStuate.AutoSize = true;
            this.lbl_deviceStuate.Location = new System.Drawing.Point(203, 0);
            this.lbl_deviceStuate.Name = "lbl_deviceStuate";
            this.lbl_deviceStuate.Size = new System.Drawing.Size(106, 24);
            this.lbl_deviceStuate.TabIndex = 3;
            this.lbl_deviceStuate.Text = "在线状态";
            // 
            // lbl_deviceID
            // 
            this.lbl_deviceID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_deviceID.AutoSize = true;
            this.lbl_deviceID.Location = new System.Drawing.Point(315, 0);
            this.lbl_deviceID.Name = "lbl_deviceID";
            this.lbl_deviceID.Size = new System.Drawing.Size(82, 24);
            this.lbl_deviceID.TabIndex = 1;
            this.lbl_deviceID.Text = "设备ID";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.Controls.Add(this.btn_DeviceEnable);
            this.flowLayoutPanel2.Controls.Add(this.btn_Connection);
            this.flowLayoutPanel2.Controls.Add(this.btn_SaveConfig);
            this.flowLayoutPanel2.Controls.Add(this.btn_ClearConfig);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 645);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1123, 64);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_DeviceEnable
            // 
            this.btn_DeviceEnable.Location = new System.Drawing.Point(3, 3);
            this.btn_DeviceEnable.Name = "btn_DeviceEnable";
            this.btn_DeviceEnable.Size = new System.Drawing.Size(135, 61);
            this.btn_DeviceEnable.TabIndex = 0;
            this.btn_DeviceEnable.Text = "启/禁开关";
            this.btn_DeviceEnable.UseVisualStyleBackColor = true;
            // 
            // btn_Connection
            // 
            this.btn_Connection.Location = new System.Drawing.Point(144, 3);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(135, 61);
            this.btn_Connection.TabIndex = 1;
            this.btn_Connection.Text = "连/断设备";
            this.btn_Connection.UseVisualStyleBackColor = true;
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.Location = new System.Drawing.Point(285, 3);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(135, 61);
            this.btn_SaveConfig.TabIndex = 2;
            this.btn_SaveConfig.Text = "保存配置";
            this.btn_SaveConfig.UseVisualStyleBackColor = true;
            // 
            // btn_ClearConfig
            // 
            this.btn_ClearConfig.Location = new System.Drawing.Point(426, 3);
            this.btn_ClearConfig.Name = "btn_ClearConfig";
            this.btn_ClearConfig.Size = new System.Drawing.Size(135, 61);
            this.btn_ClearConfig.TabIndex = 3;
            this.btn_ClearConfig.Text = "清除配置";
            this.btn_ClearConfig.UseVisualStyleBackColor = true;
            this.btn_ClearConfig.Click += new System.EventHandler(this.btn_ClearConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 566);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nud_Port, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nud_PlcTimeout, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbx_PlcBaudRate, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcBaudRate, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcTimeout, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcStationNo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcProtocol, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcPort, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbx_PlcProtocol, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PlcIP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nud_PlcStationNo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_PlcIP, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1117, 532);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nud_PlcTimeout
            // 
            this.nud_PlcTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_PlcTimeout.Location = new System.Drawing.Point(561, 324);
            this.nud_PlcTimeout.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_PlcTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_PlcTimeout.Name = "nud_PlcTimeout";
            this.nud_PlcTimeout.Size = new System.Drawing.Size(120, 35);
            this.nud_PlcTimeout.TabIndex = 17;
            this.nud_PlcTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbx_PlcBaudRate
            // 
            this.cbx_PlcBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_PlcBaudRate.FormattingEnabled = true;
            this.cbx_PlcBaudRate.Location = new System.Drawing.Point(561, 402);
            this.cbx_PlcBaudRate.Name = "cbx_PlcBaudRate";
            this.cbx_PlcBaudRate.Size = new System.Drawing.Size(150, 32);
            this.cbx_PlcBaudRate.TabIndex = 16;
            // 
            // lbl_PlcBaudRate
            // 
            this.lbl_PlcBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcBaudRate.AutoSize = true;
            this.lbl_PlcBaudRate.Location = new System.Drawing.Point(3, 406);
            this.lbl_PlcBaudRate.Name = "lbl_PlcBaudRate";
            this.lbl_PlcBaudRate.Size = new System.Drawing.Size(82, 24);
            this.lbl_PlcBaudRate.TabIndex = 15;
            this.lbl_PlcBaudRate.Text = "波特率";
            // 
            // lbl_PlcTimeout
            // 
            this.lbl_PlcTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcTimeout.AutoSize = true;
            this.lbl_PlcTimeout.Location = new System.Drawing.Point(3, 330);
            this.lbl_PlcTimeout.Name = "lbl_PlcTimeout";
            this.lbl_PlcTimeout.Size = new System.Drawing.Size(106, 24);
            this.lbl_PlcTimeout.TabIndex = 11;
            this.lbl_PlcTimeout.Text = "超时时间";
            // 
            // lbl_PlcStationNo
            // 
            this.lbl_PlcStationNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcStationNo.AutoSize = true;
            this.lbl_PlcStationNo.Location = new System.Drawing.Point(3, 254);
            this.lbl_PlcStationNo.Name = "lbl_PlcStationNo";
            this.lbl_PlcStationNo.Size = new System.Drawing.Size(58, 24);
            this.lbl_PlcStationNo.TabIndex = 7;
            this.lbl_PlcStationNo.Text = "站号";
            // 
            // lbl_PlcProtocol
            // 
            this.lbl_PlcProtocol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcProtocol.AutoSize = true;
            this.lbl_PlcProtocol.Location = new System.Drawing.Point(3, 178);
            this.lbl_PlcProtocol.Name = "lbl_PlcProtocol";
            this.lbl_PlcProtocol.Size = new System.Drawing.Size(106, 24);
            this.lbl_PlcProtocol.TabIndex = 6;
            this.lbl_PlcProtocol.Text = "通讯协议";
            // 
            // lbl_PlcPort
            // 
            this.lbl_PlcPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcPort.AutoSize = true;
            this.lbl_PlcPort.Location = new System.Drawing.Point(3, 102);
            this.lbl_PlcPort.Name = "lbl_PlcPort";
            this.lbl_PlcPort.Size = new System.Drawing.Size(58, 24);
            this.lbl_PlcPort.TabIndex = 5;
            this.lbl_PlcPort.Text = "端口";
            // 
            // cbx_PlcProtocol
            // 
            this.cbx_PlcProtocol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_PlcProtocol.FormattingEnabled = true;
            this.cbx_PlcProtocol.Location = new System.Drawing.Point(561, 174);
            this.cbx_PlcProtocol.Name = "cbx_PlcProtocol";
            this.cbx_PlcProtocol.Size = new System.Drawing.Size(150, 32);
            this.cbx_PlcProtocol.TabIndex = 2;
            this.cbx_PlcProtocol.SelectedIndexChanged += new System.EventHandler(this.cbx_PlcProtocol_SelectedIndexChanged);
            // 
            // lbl_PlcIP
            // 
            this.lbl_PlcIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PlcIP.AutoSize = true;
            this.lbl_PlcIP.Location = new System.Drawing.Point(3, 26);
            this.lbl_PlcIP.Name = "lbl_PlcIP";
            this.lbl_PlcIP.Size = new System.Drawing.Size(34, 24);
            this.lbl_PlcIP.TabIndex = 4;
            this.lbl_PlcIP.Text = "IP";
            // 
            // nud_PlcStationNo
            // 
            this.nud_PlcStationNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_PlcStationNo.Location = new System.Drawing.Point(561, 248);
            this.nud_PlcStationNo.Name = "nud_PlcStationNo";
            this.nud_PlcStationNo.Size = new System.Drawing.Size(120, 35);
            this.nud_PlcStationNo.TabIndex = 10;
            // 
            // txt_PlcIP
            // 
            this.txt_PlcIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PlcIP.Location = new System.Drawing.Point(561, 20);
            this.txt_PlcIP.Name = "txt_PlcIP";
            this.txt_PlcIP.Size = new System.Drawing.Size(100, 35);
            this.txt_PlcIP.TabIndex = 12;
            // 
            // nud_Port
            // 
            this.nud_Port.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_Port.Location = new System.Drawing.Point(561, 96);
            this.nud_Port.Maximum = new decimal(new int[] {
            560,
            0,
            0,
            0});
            this.nud_Port.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Port.Name = "nud_Port";
            this.nud_Port.Size = new System.Drawing.Size(120, 35);
            this.nud_Port.TabIndex = 18;
            this.nud_Port.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // PlcDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlcDetailUC";
            this.Size = new System.Drawing.Size(1145, 728);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlcTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlcStationNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_DeviceName;
        private System.Windows.Forms.Label lbl_deviceType;
        private System.Windows.Forms.Label lbl_deviceStuate;
        private System.Windows.Forms.Label lbl_deviceID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_DeviceEnable;
        private System.Windows.Forms.Button btn_Connection;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.Button btn_ClearConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_PlcStationNo;
        private System.Windows.Forms.Label lbl_PlcProtocol;
        private System.Windows.Forms.Label lbl_PlcPort;
        private System.Windows.Forms.ComboBox cbx_PlcProtocol;
        private System.Windows.Forms.Label lbl_PlcIP;
        private System.Windows.Forms.NumericUpDown nud_PlcStationNo;
        private System.Windows.Forms.Label lbl_PlcTimeout;
        private System.Windows.Forms.TextBox txt_PlcIP;
        private System.Windows.Forms.Label lbl_PlcBaudRate;
        private System.Windows.Forms.ComboBox cbx_PlcBaudRate;
        private System.Windows.Forms.NumericUpDown nud_PlcTimeout;
        private System.Windows.Forms.NumericUpDown nud_Port;
    }
}
