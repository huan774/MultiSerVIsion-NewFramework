namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    partial class CameraDateilUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_CamTrigger = new System.Windows.Forms.ComboBox();
            this.cbx_CamType = new System.Windows.Forms.ComboBox();
            this.lbl_CamChannel = new System.Windows.Forms.Label();
            this.lbl_CamPort = new System.Windows.Forms.Label();
            this.lbl_CamTriggerMode = new System.Windows.Forms.Label();
            this.lbl_CamType = new System.Windows.Forms.Label();
            this.nud_CamChannel = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_DeviceEnable = new System.Windows.Forms.Button();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.btn_ClearConfig = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_DeviceName = new System.Windows.Forms.Label();
            this.lbl_deviceType = new System.Windows.Forms.Label();
            this.lbl_deviceStuate = new System.Windows.Forms.Label();
            this.lbl_deviceID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num_CamPort = new System.Windows.Forms.NumericUpDown();
            this.lbl_CamExposureUs = new System.Windows.Forms.Label();
            this.lbl_CamGiain = new System.Windows.Forms.Label();
            this.num_CamExposureUs = new System.Windows.Forms.NumericUpDown();
            this.num_CamGiain = new System.Windows.Forms.NumericUpDown();
            this.chk_AutoExposureDefault = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CamChannel)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CamPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CamExposureUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CamGiain)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.chk_AutoExposureDefault, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.num_CamGiain, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.num_CamExposureUs, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamGiain, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamExposureUs, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbx_CamTrigger, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbx_CamType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamChannel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamPort, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamTriggerMode, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CamType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nud_CamChannel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.num_CamPort, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1117, 532);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbx_CamTrigger
            // 
            this.cbx_CamTrigger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_CamTrigger.FormattingEnabled = true;
            this.cbx_CamTrigger.Location = new System.Drawing.Point(561, 98);
            this.cbx_CamTrigger.Name = "cbx_CamTrigger";
            this.cbx_CamTrigger.Size = new System.Drawing.Size(150, 32);
            this.cbx_CamTrigger.TabIndex = 9;
            // 
            // cbx_CamType
            // 
            this.cbx_CamType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_CamType.FormattingEnabled = true;
            this.cbx_CamType.Location = new System.Drawing.Point(561, 22);
            this.cbx_CamType.Name = "cbx_CamType";
            this.cbx_CamType.Size = new System.Drawing.Size(150, 32);
            this.cbx_CamType.TabIndex = 8;
            // 
            // lbl_CamChannel
            // 
            this.lbl_CamChannel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamChannel.AutoSize = true;
            this.lbl_CamChannel.Location = new System.Drawing.Point(3, 254);
            this.lbl_CamChannel.Name = "lbl_CamChannel";
            this.lbl_CamChannel.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamChannel.TabIndex = 7;
            this.lbl_CamChannel.Text = "触发通道";
            // 
            // lbl_CamPort
            // 
            this.lbl_CamPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamPort.AutoSize = true;
            this.lbl_CamPort.Location = new System.Drawing.Point(3, 178);
            this.lbl_CamPort.Name = "lbl_CamPort";
            this.lbl_CamPort.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamPort.TabIndex = 6;
            this.lbl_CamPort.Text = "通信端口";
            // 
            // lbl_CamTriggerMode
            // 
            this.lbl_CamTriggerMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamTriggerMode.AutoSize = true;
            this.lbl_CamTriggerMode.Location = new System.Drawing.Point(3, 102);
            this.lbl_CamTriggerMode.Name = "lbl_CamTriggerMode";
            this.lbl_CamTriggerMode.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamTriggerMode.TabIndex = 5;
            this.lbl_CamTriggerMode.Text = "触发模式";
            // 
            // lbl_CamType
            // 
            this.lbl_CamType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamType.AutoSize = true;
            this.lbl_CamType.Location = new System.Drawing.Point(3, 26);
            this.lbl_CamType.Name = "lbl_CamType";
            this.lbl_CamType.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamType.TabIndex = 4;
            this.lbl_CamType.Text = "接口类型";
            // 
            // nud_CamChannel
            // 
            this.nud_CamChannel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_CamChannel.Location = new System.Drawing.Point(561, 248);
            this.nud_CamChannel.Name = "nud_CamChannel";
            this.nud_CamChannel.Size = new System.Drawing.Size(120, 35);
            this.nud_CamChannel.TabIndex = 10;
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
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // btn_ClearConfig
            // 
            this.btn_ClearConfig.Location = new System.Drawing.Point(426, 3);
            this.btn_ClearConfig.Name = "btn_ClearConfig";
            this.btn_ClearConfig.Size = new System.Drawing.Size(135, 61);
            this.btn_ClearConfig.TabIndex = 3;
            this.btn_ClearConfig.Text = "清除配置";
            this.btn_ClearConfig.UseVisualStyleBackColor = true;
            this.btn_ClearConfig.Click += new System.EventHandler(this.btnClear_Click);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // num_CamPort
            // 
            this.num_CamPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_CamPort.Location = new System.Drawing.Point(561, 172);
            this.num_CamPort.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.num_CamPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_CamPort.Name = "num_CamPort";
            this.num_CamPort.Size = new System.Drawing.Size(120, 35);
            this.num_CamPort.TabIndex = 13;
            this.num_CamPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbl_CamExposureUs
            // 
            this.lbl_CamExposureUs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamExposureUs.AutoSize = true;
            this.lbl_CamExposureUs.Location = new System.Drawing.Point(3, 330);
            this.lbl_CamExposureUs.Name = "lbl_CamExposureUs";
            this.lbl_CamExposureUs.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamExposureUs.TabIndex = 18;
            this.lbl_CamExposureUs.Text = "默认曝光";
            // 
            // lbl_CamGiain
            // 
            this.lbl_CamGiain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CamGiain.AutoSize = true;
            this.lbl_CamGiain.Location = new System.Drawing.Point(3, 406);
            this.lbl_CamGiain.Name = "lbl_CamGiain";
            this.lbl_CamGiain.Size = new System.Drawing.Size(106, 24);
            this.lbl_CamGiain.TabIndex = 20;
            this.lbl_CamGiain.Text = "默认增益";
            // 
            // num_CamExposureUs
            // 
            this.num_CamExposureUs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_CamExposureUs.Location = new System.Drawing.Point(561, 324);
            this.num_CamExposureUs.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.num_CamExposureUs.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.num_CamExposureUs.Name = "num_CamExposureUs";
            this.num_CamExposureUs.Size = new System.Drawing.Size(120, 35);
            this.num_CamExposureUs.TabIndex = 21;
            this.num_CamExposureUs.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // num_CamGiain
            // 
            this.num_CamGiain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_CamGiain.Location = new System.Drawing.Point(561, 400);
            this.num_CamGiain.Name = "num_CamGiain";
            this.num_CamGiain.Size = new System.Drawing.Size(120, 35);
            this.num_CamGiain.TabIndex = 22;
            // 
            // chk_AutoExposureDefault
            // 
            this.chk_AutoExposureDefault.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_AutoExposureDefault.AutoSize = true;
            this.chk_AutoExposureDefault.Location = new System.Drawing.Point(561, 480);
            this.chk_AutoExposureDefault.Name = "chk_AutoExposureDefault";
            this.chk_AutoExposureDefault.Size = new System.Drawing.Size(138, 28);
            this.chk_AutoExposureDefault.TabIndex = 23;
            this.chk_AutoExposureDefault.Text = "自动曝光";
            this.chk_AutoExposureDefault.UseVisualStyleBackColor = true;
            // 
            // CameraDateilUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CameraDateilUC";
            this.Size = new System.Drawing.Size(1145, 728);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CamChannel)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_CamPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CamExposureUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CamGiain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_DeviceEnable;
        private System.Windows.Forms.Button btn_Connection;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.Button btn_ClearConfig;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_DeviceName;
        private System.Windows.Forms.Label lbl_deviceType;
        private System.Windows.Forms.Label lbl_deviceStuate;
        private System.Windows.Forms.Label lbl_deviceID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_CamChannel;
        private System.Windows.Forms.Label lbl_CamPort;
        private System.Windows.Forms.Label lbl_CamTriggerMode;
        private System.Windows.Forms.Label lbl_CamType;
        private System.Windows.Forms.ComboBox cbx_CamTrigger;
        private System.Windows.Forms.ComboBox cbx_CamType;
        private System.Windows.Forms.NumericUpDown nud_CamChannel;
        private System.Windows.Forms.NumericUpDown num_CamPort;
        private System.Windows.Forms.NumericUpDown num_CamGiain;
        private System.Windows.Forms.NumericUpDown num_CamExposureUs;
        private System.Windows.Forms.Label lbl_CamGiain;
        private System.Windows.Forms.Label lbl_CamExposureUs;
        private System.Windows.Forms.CheckBox chk_AutoExposureDefault;
    }
}
