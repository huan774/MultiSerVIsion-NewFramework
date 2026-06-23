namespace MultiSerVIsion.Solution.Presentation.UserControls
{
    partial class UCVisionView
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
            this.lblImgStatus = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCerameImg4 = new System.Windows.Forms.GroupBox();
            this.grpCerameImg3 = new System.Windows.Forms.GroupBox();
            this.grpCerameImg2 = new System.Windows.Forms.GroupBox();
            this.grpCerameImg1 = new System.Windows.Forms.GroupBox();
            this.picVisionImg = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxProtocolType = new System.Windows.Forms.ComboBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.nudGain = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lblprotocolType = new System.Windows.Forms.Label();
            this.lblLightVakue = new System.Windows.Forms.Label();
            this.lblTriggerMode = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.lblExposure = new System.Windows.Forms.Label();
            this.nudExposure = new System.Windows.Forms.NumericUpDown();
            this.cbxTriggerMode = new System.Windows.Forms.ComboBox();
            this.trackLight = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSingleGrab = new System.Windows.Forms.Button();
            this.btnContinuousGrab = new System.Windows.Forms.Button();
            this.btnStopGrab = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnClearImg = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpCerameImg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisionImg)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblImgStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblImgStatus
            // 
            this.lblImgStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblImgStatus.AutoSize = true;
            this.lblImgStatus.Location = new System.Drawing.Point(11, 31);
            this.lblImgStatus.Name = "lblImgStatus";
            this.lblImgStatus.Size = new System.Drawing.Size(382, 24);
            this.lblImgStatus.TabIndex = 0;
            this.lblImgStatus.Text = "图像状态:无图像/采集中/取图失败";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(11, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1107, 560);
            this.splitContainer1.SplitterDistance = 780;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grpCerameImg4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpCerameImg3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpCerameImg2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpCerameImg1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 560);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpCerameImg4
            // 
            this.grpCerameImg4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCerameImg4.Location = new System.Drawing.Point(393, 283);
            this.grpCerameImg4.Name = "grpCerameImg4";
            this.grpCerameImg4.Size = new System.Drawing.Size(384, 274);
            this.grpCerameImg4.TabIndex = 3;
            this.grpCerameImg4.TabStop = false;
            this.grpCerameImg4.Text = "相机4";
            // 
            // grpCerameImg3
            // 
            this.grpCerameImg3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCerameImg3.Location = new System.Drawing.Point(3, 283);
            this.grpCerameImg3.Name = "grpCerameImg3";
            this.grpCerameImg3.Size = new System.Drawing.Size(384, 274);
            this.grpCerameImg3.TabIndex = 2;
            this.grpCerameImg3.TabStop = false;
            this.grpCerameImg3.Text = "相机3";
            // 
            // grpCerameImg2
            // 
            this.grpCerameImg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCerameImg2.Location = new System.Drawing.Point(393, 3);
            this.grpCerameImg2.Name = "grpCerameImg2";
            this.grpCerameImg2.Size = new System.Drawing.Size(384, 274);
            this.grpCerameImg2.TabIndex = 1;
            this.grpCerameImg2.TabStop = false;
            this.grpCerameImg2.Text = "相机2";
            // 
            // grpCerameImg1
            // 
            this.grpCerameImg1.Controls.Add(this.picVisionImg);
            this.grpCerameImg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCerameImg1.Location = new System.Drawing.Point(3, 3);
            this.grpCerameImg1.Name = "grpCerameImg1";
            this.grpCerameImg1.Size = new System.Drawing.Size(384, 274);
            this.grpCerameImg1.TabIndex = 0;
            this.grpCerameImg1.TabStop = false;
            this.grpCerameImg1.Text = "相机1";
            // 
            // picVisionImg
            // 
            this.picVisionImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVisionImg.Location = new System.Drawing.Point(3, 31);
            this.picVisionImg.Name = "picVisionImg";
            this.picVisionImg.Size = new System.Drawing.Size(378, 240);
            this.picVisionImg.TabIndex = 0;
            this.picVisionImg.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 560);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "相机配置";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cbxProtocolType, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown6, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.nudGain, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblprotocolType, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblLightVakue, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblTriggerMode, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblGain, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblExposure, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudExposure, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxTriggerMode, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.trackLight, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 526);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cbxProtocolType
            // 
            this.cbxProtocolType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxProtocolType.FormattingEnabled = true;
            this.cbxProtocolType.Location = new System.Drawing.Point(161, 375);
            this.cbxProtocolType.Name = "cbxProtocolType";
            this.cbxProtocolType.Size = new System.Drawing.Size(121, 32);
            this.cbxProtocolType.TabIndex = 19;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown6.Location = new System.Drawing.Point(161, 463);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown6.TabIndex = 16;
            // 
            // nudGain
            // 
            this.nudGain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGain.Location = new System.Drawing.Point(161, 113);
            this.nudGain.Name = "nudGain";
            this.nudGain.Size = new System.Drawing.Size(120, 35);
            this.nudGain.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // lblprotocolType
            // 
            this.lblprotocolType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblprotocolType.AutoSize = true;
            this.lblprotocolType.Location = new System.Drawing.Point(3, 379);
            this.lblprotocolType.Name = "lblprotocolType";
            this.lblprotocolType.Size = new System.Drawing.Size(82, 24);
            this.lblprotocolType.TabIndex = 8;
            this.lblprotocolType.Text = "label1";
            // 
            // lblLightVakue
            // 
            this.lblLightVakue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLightVakue.AutoSize = true;
            this.lblLightVakue.Location = new System.Drawing.Point(3, 292);
            this.lblLightVakue.Name = "lblLightVakue";
            this.lblLightVakue.Size = new System.Drawing.Size(106, 24);
            this.lblLightVakue.TabIndex = 6;
            this.lblLightVakue.Text = "光源亮度";
            // 
            // lblTriggerMode
            // 
            this.lblTriggerMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTriggerMode.AutoSize = true;
            this.lblTriggerMode.Location = new System.Drawing.Point(3, 205);
            this.lblTriggerMode.Name = "lblTriggerMode";
            this.lblTriggerMode.Size = new System.Drawing.Size(106, 24);
            this.lblTriggerMode.TabIndex = 4;
            this.lblTriggerMode.Text = "触发模式";
            // 
            // lblGain
            // 
            this.lblGain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(3, 118);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(58, 24);
            this.lblGain.TabIndex = 2;
            this.lblGain.Text = "增益";
            // 
            // lblExposure
            // 
            this.lblExposure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExposure.AutoSize = true;
            this.lblExposure.Location = new System.Drawing.Point(3, 31);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.Size = new System.Drawing.Size(58, 24);
            this.lblExposure.TabIndex = 0;
            this.lblExposure.Text = "曝光";
            // 
            // nudExposure
            // 
            this.nudExposure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudExposure.Location = new System.Drawing.Point(161, 26);
            this.nudExposure.Name = "nudExposure";
            this.nudExposure.Size = new System.Drawing.Size(120, 35);
            this.nudExposure.TabIndex = 11;
            // 
            // cbxTriggerMode
            // 
            this.cbxTriggerMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxTriggerMode.FormattingEnabled = true;
            this.cbxTriggerMode.Location = new System.Drawing.Point(161, 201);
            this.cbxTriggerMode.Name = "cbxTriggerMode";
            this.cbxTriggerMode.Size = new System.Drawing.Size(121, 32);
            this.cbxTriggerMode.TabIndex = 17;
            // 
            // trackLight
            // 
            this.trackLight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackLight.Location = new System.Drawing.Point(161, 264);
            this.trackLight.Name = "trackLight";
            this.trackLight.Size = new System.Drawing.Size(153, 81);
            this.trackLight.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSingleGrab);
            this.flowLayoutPanel1.Controls.Add(this.btnContinuousGrab);
            this.flowLayoutPanel1.Controls.Add(this.btnStopGrab);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveImage);
            this.flowLayoutPanel1.Controls.Add(this.btnClearImg);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 647);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1107, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSingleGrab
            // 
            this.btnSingleGrab.Location = new System.Drawing.Point(3, 3);
            this.btnSingleGrab.Name = "btnSingleGrab";
            this.btnSingleGrab.Size = new System.Drawing.Size(120, 51);
            this.btnSingleGrab.TabIndex = 0;
            this.btnSingleGrab.Text = "单张取图";
            this.btnSingleGrab.UseVisualStyleBackColor = true;
            // 
            // btnContinuousGrab
            // 
            this.btnContinuousGrab.Location = new System.Drawing.Point(129, 3);
            this.btnContinuousGrab.Name = "btnContinuousGrab";
            this.btnContinuousGrab.Size = new System.Drawing.Size(120, 51);
            this.btnContinuousGrab.TabIndex = 1;
            this.btnContinuousGrab.Text = "连续采集";
            this.btnContinuousGrab.UseVisualStyleBackColor = true;
            // 
            // btnStopGrab
            // 
            this.btnStopGrab.Location = new System.Drawing.Point(255, 3);
            this.btnStopGrab.Name = "btnStopGrab";
            this.btnStopGrab.Size = new System.Drawing.Size(120, 51);
            this.btnStopGrab.TabIndex = 2;
            this.btnStopGrab.Text = "停止采图";
            this.btnStopGrab.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(381, 3);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(120, 51);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "保存图像";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // btnClearImg
            // 
            this.btnClearImg.Location = new System.Drawing.Point(507, 3);
            this.btnClearImg.Name = "btnClearImg";
            this.btnClearImg.Size = new System.Drawing.Size(120, 51);
            this.btnClearImg.TabIndex = 4;
            this.btnClearImg.Text = "清空图像";
            this.btnClearImg.UseVisualStyleBackColor = true;
            // 
            // UCVisionView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCVisionView";
            this.Size = new System.Drawing.Size(1145, 728);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpCerameImg1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVisionImg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblImgStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSingleGrab;
        private System.Windows.Forms.Button btnContinuousGrab;
        private System.Windows.Forms.Button btnStopGrab;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnClearImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpCerameImg4;
        private System.Windows.Forms.GroupBox grpCerameImg3;
        private System.Windows.Forms.GroupBox grpCerameImg2;
        private System.Windows.Forms.GroupBox grpCerameImg1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox picVisionImg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblprotocolType;
        private System.Windows.Forms.Label lblLightVakue;
        private System.Windows.Forms.Label lblTriggerMode;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Label lblExposure;
        private System.Windows.Forms.NumericUpDown nudExposure;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown nudGain;
        private System.Windows.Forms.ComboBox cbxTriggerMode;
        private System.Windows.Forms.TrackBar trackLight;
        private System.Windows.Forms.ComboBox cbxProtocolType;
    }
}
