namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    partial class CardDetailUC
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
            this.lbl_PulseEquivalent = new System.Windows.Forms.Label();
            this.chk_AutoHomeOnStart = new System.Windows.Forms.CheckBox();
            this.chk_LimitEnable = new System.Windows.Forms.CheckBox();
            this.nud_AccTime = new System.Windows.Forms.NumericUpDown();
            this.cbx_EncoderMode = new System.Windows.Forms.ComboBox();
            this.nud_PulseFreq = new System.Windows.Forms.NumericUpDown();
            this.nud_CardIndex = new System.Windows.Forms.NumericUpDown();
            this.lbl_EncoderMode = new System.Windows.Forms.Label();
            this.lbl_AccTime = new System.Windows.Forms.Label();
            this.lbl_PulseFreq = new System.Windows.Forms.Label();
            this.lbl_CardIndex = new System.Windows.Forms.Label();
            this.nud_PulseEquivalent = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PulseFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PulseEquivalent)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel2.Controls.Add(this.nud_PulseEquivalent, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PulseEquivalent, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.chk_AutoHomeOnStart, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.chk_LimitEnable, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.nud_AccTime, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbx_EncoderMode, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.nud_PulseFreq, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nud_CardIndex, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_EncoderMode, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_AccTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_PulseFreq, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_CardIndex, 0, 0);
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
            // lbl_PulseEquivalent
            // 
            this.lbl_PulseEquivalent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PulseEquivalent.AutoSize = true;
            this.lbl_PulseEquivalent.Location = new System.Drawing.Point(3, 330);
            this.lbl_PulseEquivalent.Name = "lbl_PulseEquivalent";
            this.lbl_PulseEquivalent.Size = new System.Drawing.Size(106, 24);
            this.lbl_PulseEquivalent.TabIndex = 24;
            this.lbl_PulseEquivalent.Text = "脉冲当量";
            // 
            // chk_AutoHomeOnStart
            // 
            this.chk_AutoHomeOnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_AutoHomeOnStart.AutoSize = true;
            this.chk_AutoHomeOnStart.Location = new System.Drawing.Point(561, 480);
            this.chk_AutoHomeOnStart.Name = "chk_AutoHomeOnStart";
            this.chk_AutoHomeOnStart.Size = new System.Drawing.Size(186, 28);
            this.chk_AutoHomeOnStart.TabIndex = 23;
            this.chk_AutoHomeOnStart.Text = "上电自动回零";
            this.chk_AutoHomeOnStart.UseVisualStyleBackColor = true;
            // 
            // chk_LimitEnable
            // 
            this.chk_LimitEnable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_LimitEnable.AutoSize = true;
            this.chk_LimitEnable.Location = new System.Drawing.Point(3, 480);
            this.chk_LimitEnable.Name = "chk_LimitEnable";
            this.chk_LimitEnable.Size = new System.Drawing.Size(186, 28);
            this.chk_LimitEnable.TabIndex = 22;
            this.chk_LimitEnable.Text = "正负限位使能";
            this.chk_LimitEnable.UseVisualStyleBackColor = true;
            // 
            // nud_AccTime
            // 
            this.nud_AccTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_AccTime.Location = new System.Drawing.Point(561, 172);
            this.nud_AccTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_AccTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_AccTime.Name = "nud_AccTime";
            this.nud_AccTime.Size = new System.Drawing.Size(120, 35);
            this.nud_AccTime.TabIndex = 17;
            this.nud_AccTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbx_EncoderMode
            // 
            this.cbx_EncoderMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_EncoderMode.FormattingEnabled = true;
            this.cbx_EncoderMode.Location = new System.Drawing.Point(561, 250);
            this.cbx_EncoderMode.Name = "cbx_EncoderMode";
            this.cbx_EncoderMode.Size = new System.Drawing.Size(150, 32);
            this.cbx_EncoderMode.TabIndex = 16;
            // 
            // nud_PulseFreq
            // 
            this.nud_PulseFreq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_PulseFreq.Location = new System.Drawing.Point(561, 96);
            this.nud_PulseFreq.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.nud_PulseFreq.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nud_PulseFreq.Name = "nud_PulseFreq";
            this.nud_PulseFreq.Size = new System.Drawing.Size(120, 35);
            this.nud_PulseFreq.TabIndex = 15;
            this.nud_PulseFreq.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // nud_CardIndex
            // 
            this.nud_CardIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_CardIndex.Location = new System.Drawing.Point(561, 20);
            this.nud_CardIndex.Name = "nud_CardIndex";
            this.nud_CardIndex.Size = new System.Drawing.Size(120, 35);
            this.nud_CardIndex.TabIndex = 14;
            // 
            // lbl_EncoderMode
            // 
            this.lbl_EncoderMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_EncoderMode.AutoSize = true;
            this.lbl_EncoderMode.Location = new System.Drawing.Point(3, 254);
            this.lbl_EncoderMode.Name = "lbl_EncoderMode";
            this.lbl_EncoderMode.Size = new System.Drawing.Size(130, 24);
            this.lbl_EncoderMode.TabIndex = 7;
            this.lbl_EncoderMode.Text = "编码器模式";
            // 
            // lbl_AccTime
            // 
            this.lbl_AccTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_AccTime.AutoSize = true;
            this.lbl_AccTime.Location = new System.Drawing.Point(3, 178);
            this.lbl_AccTime.Name = "lbl_AccTime";
            this.lbl_AccTime.Size = new System.Drawing.Size(130, 24);
            this.lbl_AccTime.TabIndex = 6;
            this.lbl_AccTime.Text = "加减速时间";
            // 
            // lbl_PulseFreq
            // 
            this.lbl_PulseFreq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_PulseFreq.AutoSize = true;
            this.lbl_PulseFreq.Location = new System.Drawing.Point(3, 102);
            this.lbl_PulseFreq.Name = "lbl_PulseFreq";
            this.lbl_PulseFreq.Size = new System.Drawing.Size(154, 24);
            this.lbl_PulseFreq.TabIndex = 5;
            this.lbl_PulseFreq.Text = "脉冲频率上限";
            // 
            // lbl_CardIndex
            // 
            this.lbl_CardIndex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CardIndex.AutoSize = true;
            this.lbl_CardIndex.Location = new System.Drawing.Point(3, 26);
            this.lbl_CardIndex.Name = "lbl_CardIndex";
            this.lbl_CardIndex.Size = new System.Drawing.Size(106, 24);
            this.lbl_CardIndex.TabIndex = 4;
            this.lbl_CardIndex.Text = "卡号索引";
            // 
            // nud_PulseEquivalent
            // 
            this.nud_PulseEquivalent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_PulseEquivalent.Location = new System.Drawing.Point(561, 324);
            this.nud_PulseEquivalent.Name = "nud_PulseEquivalent";
            this.nud_PulseEquivalent.Size = new System.Drawing.Size(120, 35);
            this.nud_PulseEquivalent.TabIndex = 25;
            // 
            // CardDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CardDetailUC";
            this.Size = new System.Drawing.Size(1145, 728);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PulseFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PulseEquivalent)).EndInit();
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
        private System.Windows.Forms.Label lbl_EncoderMode;
        private System.Windows.Forms.Label lbl_AccTime;
        private System.Windows.Forms.Label lbl_PulseFreq;
        private System.Windows.Forms.Label lbl_CardIndex;
        private System.Windows.Forms.NumericUpDown nud_AccTime;
        private System.Windows.Forms.ComboBox cbx_EncoderMode;
        private System.Windows.Forms.NumericUpDown nud_PulseFreq;
        private System.Windows.Forms.NumericUpDown nud_CardIndex;
        private System.Windows.Forms.CheckBox chk_AutoHomeOnStart;
        private System.Windows.Forms.CheckBox chk_LimitEnable;
        private System.Windows.Forms.Label lbl_PulseEquivalent;
        private System.Windows.Forms.NumericUpDown nud_PulseEquivalent;
    }
}
