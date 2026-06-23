namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    partial class UCMonitorView
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleRun = new System.Windows.Forms.Label();
            this.lblRunStaus = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCoodRate = new System.Windows.Forms.Label();
            this.lblRateTxt = new System.Windows.Forms.Label();
            this.txtNgTxt = new System.Windows.Forms.Label();
            this.lblNgTxt = new System.Windows.Forms.Label();
            this.txtOkCount = new System.Windows.Forms.Label();
            this.lblOkTex = new System.Windows.Forms.Label();
            this.txtTotalCount = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLIghtState = new System.Windows.Forms.Label();
            this.lblLightStatus = new System.Windows.Forms.Label();
            this.lblPlvState = new System.Windows.Forms.Label();
            this.lblPlsStatus = new System.Windows.Forms.Label();
            this.lblCamState = new System.Windows.Forms.Label();
            this.lblCamStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClearCount = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTitleRun, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRunStaus, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTitleRun
            // 
            this.lblTitleRun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleRun.AutoSize = true;
            this.lblTitleRun.Location = new System.Drawing.Point(3, 15);
            this.lblTitleRun.Name = "lblTitleRun";
            this.lblTitleRun.Size = new System.Drawing.Size(154, 24);
            this.lblTitleRun.TabIndex = 0;
            this.lblTitleRun.Text = "当前整机状态";
            // 
            // lblRunStaus
            // 
            this.lblRunStaus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRunStaus.AutoSize = true;
            this.lblRunStaus.Location = new System.Drawing.Point(556, 15);
            this.lblRunStaus.Name = "lblRunStaus";
            this.lblRunStaus.Size = new System.Drawing.Size(238, 24);
            this.lblRunStaus.TabIndex = 1;
            this.lblRunStaus.Text = "待机/显示/运行/报警\r\n";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 71);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1107, 560);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产量统计";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.50656F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.49344F));
            this.tableLayoutPanel4.Controls.Add(this.txtCoodRate, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblRateTxt, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtNgTxt, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblNgTxt, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtOkCount, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblOkTex, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtTotalCount, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalTxt, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(541, 520);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtCoodRate
            // 
            this.txtCoodRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCoodRate.AutoSize = true;
            this.txtCoodRate.Location = new System.Drawing.Point(260, 443);
            this.txtCoodRate.Name = "txtCoodRate";
            this.txtCoodRate.Size = new System.Drawing.Size(130, 24);
            this.txtCoodRate.TabIndex = 7;
            this.txtCoodRate.Text = "良率百分比";
            // 
            // lblRateTxt
            // 
            this.lblRateTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRateTxt.AutoSize = true;
            this.lblRateTxt.Location = new System.Drawing.Point(3, 443);
            this.lblRateTxt.Name = "lblRateTxt";
            this.lblRateTxt.Size = new System.Drawing.Size(58, 24);
            this.lblRateTxt.TabIndex = 6;
            this.lblRateTxt.Text = "良率";
            // 
            // txtNgTxt
            // 
            this.txtNgTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgTxt.AutoSize = true;
            this.txtNgTxt.Location = new System.Drawing.Point(260, 313);
            this.txtNgTxt.Name = "txtNgTxt";
            this.txtNgTxt.Size = new System.Drawing.Size(106, 24);
            this.txtNgTxt.TabIndex = 5;
            this.txtNgTxt.Text = "不良数值";
            // 
            // lblNgTxt
            // 
            this.lblNgTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgTxt.AutoSize = true;
            this.lblNgTxt.Location = new System.Drawing.Point(3, 313);
            this.lblNgTxt.Name = "lblNgTxt";
            this.lblNgTxt.Size = new System.Drawing.Size(82, 24);
            this.lblNgTxt.TabIndex = 4;
            this.lblNgTxt.Text = "NG不良";
            // 
            // txtOkCount
            // 
            this.txtOkCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOkCount.AutoSize = true;
            this.txtOkCount.Location = new System.Drawing.Point(260, 183);
            this.txtOkCount.Name = "txtOkCount";
            this.txtOkCount.Size = new System.Drawing.Size(106, 24);
            this.txtOkCount.TabIndex = 3;
            this.txtOkCount.Text = "良品数值";
            // 
            // lblOkTex
            // 
            this.lblOkTex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOkTex.AutoSize = true;
            this.lblOkTex.Location = new System.Drawing.Point(3, 183);
            this.lblOkTex.Name = "lblOkTex";
            this.lblOkTex.Size = new System.Drawing.Size(82, 24);
            this.lblOkTex.TabIndex = 2;
            this.lblOkTex.Text = "OK良品";
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalCount.AutoSize = true;
            this.txtTotalCount.Location = new System.Drawing.Point(260, 53);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(154, 24);
            this.txtTotalCount.TabIndex = 1;
            this.txtTotalCount.Text = "产值数值展示";
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Location = new System.Drawing.Point(3, 53);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(82, 24);
            this.lblTotalTxt.TabIndex = 0;
            this.lblTotalTxt.Text = "总产量";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(556, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "外设在线状态";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel5.Controls.Add(this.lblLIghtState, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblLightStatus, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblPlvState, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblPlsStatus, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblCamState, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCamStatus, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.26738F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.73262F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(542, 520);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lblLIghtState
            // 
            this.lblLIghtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLIghtState.AutoSize = true;
            this.lblLIghtState.Location = new System.Drawing.Point(274, 435);
            this.lblLIghtState.Name = "lblLIghtState";
            this.lblLIghtState.Size = new System.Drawing.Size(118, 24);
            this.lblLIghtState.TabIndex = 6;
            this.lblLIghtState.Text = "正常/异常";
            // 
            // lblLightStatus
            // 
            this.lblLightStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLightStatus.AutoSize = true;
            this.lblLightStatus.Location = new System.Drawing.Point(3, 435);
            this.lblLightStatus.Name = "lblLightStatus";
            this.lblLightStatus.Size = new System.Drawing.Size(130, 24);
            this.lblLightStatus.TabIndex = 5;
            this.lblLightStatus.Text = "光源控制器";
            // 
            // lblPlvState
            // 
            this.lblPlvState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlvState.AutoSize = true;
            this.lblPlvState.Location = new System.Drawing.Point(274, 269);
            this.lblPlvState.Name = "lblPlvState";
            this.lblPlvState.Size = new System.Drawing.Size(106, 24);
            this.lblPlvState.TabIndex = 4;
            this.lblPlvState.Text = "连接断开";
            // 
            // lblPlsStatus
            // 
            this.lblPlsStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlsStatus.AutoSize = true;
            this.lblPlsStatus.Location = new System.Drawing.Point(3, 269);
            this.lblPlsStatus.Name = "lblPlsStatus";
            this.lblPlsStatus.Size = new System.Drawing.Size(94, 24);
            this.lblPlsStatus.TabIndex = 3;
            this.lblPlsStatus.Text = "PLC通讯";
            // 
            // lblCamState
            // 
            this.lblCamState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCamState.AutoSize = true;
            this.lblCamState.Location = new System.Drawing.Point(274, 82);
            this.lblCamState.Name = "lblCamState";
            this.lblCamState.Size = new System.Drawing.Size(118, 24);
            this.lblCamState.TabIndex = 2;
            this.lblCamState.Text = "在线/离线";
            // 
            // lblCamStatus
            // 
            this.lblCamStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCamStatus.AutoSize = true;
            this.lblCamStatus.Location = new System.Drawing.Point(3, 82);
            this.lblCamStatus.Name = "lblCamStatus";
            this.lblCamStatus.Size = new System.Drawing.Size(106, 24);
            this.lblCamStatus.TabIndex = 1;
            this.lblCamStatus.Text = "相机状态";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Controls.Add(this.btnPause);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 637);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1107, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(113, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 61);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(223, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(104, 61);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 61);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "复位";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClearCount
            // 
            this.btnClearCount.Location = new System.Drawing.Point(443, 3);
            this.btnClearCount.Name = "btnClearCount";
            this.btnClearCount.Size = new System.Drawing.Size(104, 61);
            this.btnClearCount.TabIndex = 4;
            this.btnClearCount.Text = "清除";
            this.btnClearCount.UseVisualStyleBackColor = true;
            // 
            // UCMonitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCMonitorView";
            this.Size = new System.Drawing.Size(1145, 728);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitleRun;
        private System.Windows.Forms.Label lblRunStaus;
        private System.Windows.Forms.Label txtCoodRate;
        private System.Windows.Forms.Label lblRateTxt;
        private System.Windows.Forms.Label txtNgTxt;
        private System.Windows.Forms.Label lblNgTxt;
        private System.Windows.Forms.Label txtOkCount;
        private System.Windows.Forms.Label lblOkTex;
        private System.Windows.Forms.Label txtTotalCount;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Label lblLIghtState;
        private System.Windows.Forms.Label lblLightStatus;
        private System.Windows.Forms.Label lblPlvState;
        private System.Windows.Forms.Label lblPlsStatus;
        private System.Windows.Forms.Label lblCamState;
        private System.Windows.Forms.Label lblCamStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClearCount;
    }
}
