namespace MultiSerVIsion.Solution.Presentation.Winforms
{
    partial class FrmAddDevice
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
            if (disposing && (components != null))
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDevIp = new System.Windows.Forms.TextBox();
            this.lblDevName = new System.Windows.Forms.Label();
            this.lblDevIp = new System.Windows.Forms.Label();
            this.lblDevType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDevNama = new System.Windows.Forms.TextBox();
            this.cbxDevType = new System.Windows.Forms.ComboBox();
            this.btnDevCancel = new System.Windows.Forms.Button();
            this.btnDevOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDevIp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDevName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDevIp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDevType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDevNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxDevType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDevCancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDevOk, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 35);
            this.textBox4.TabIndex = 7;
            // 
            // txtDevIp
            // 
            this.txtDevIp.Location = new System.Drawing.Point(103, 40);
            this.txtDevIp.Name = "txtDevIp";
            this.txtDevIp.Size = new System.Drawing.Size(100, 35);
            this.txtDevIp.TabIndex = 5;
            // 
            // lblDevName
            // 
            this.lblDevName.AutoSize = true;
            this.lblDevName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevName.Location = new System.Drawing.Point(3, 0);
            this.lblDevName.Name = "lblDevName";
            this.lblDevName.Size = new System.Drawing.Size(94, 37);
            this.lblDevName.TabIndex = 0;
            this.lblDevName.Text = "设备";
            // 
            // lblDevIp
            // 
            this.lblDevIp.AutoSize = true;
            this.lblDevIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevIp.Location = new System.Drawing.Point(3, 37);
            this.lblDevIp.Name = "lblDevIp";
            this.lblDevIp.Size = new System.Drawing.Size(94, 37);
            this.lblDevIp.TabIndex = 1;
            this.lblDevIp.Text = "IP";
            // 
            // lblDevType
            // 
            this.lblDevType.AutoSize = true;
            this.lblDevType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevType.Location = new System.Drawing.Point(3, 74);
            this.lblDevType.Name = "lblDevType";
            this.lblDevType.Size = new System.Drawing.Size(94, 37);
            this.lblDevType.TabIndex = 2;
            this.lblDevType.Text = "类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtDevNama
            // 
            this.txtDevNama.Location = new System.Drawing.Point(103, 3);
            this.txtDevNama.Name = "txtDevNama";
            this.txtDevNama.Size = new System.Drawing.Size(100, 35);
            this.txtDevNama.TabIndex = 4;
            // 
            // cbxDevType
            // 
            this.cbxDevType.FormattingEnabled = true;
            this.cbxDevType.Location = new System.Drawing.Point(103, 77);
            this.cbxDevType.Name = "cbxDevType";
            this.cbxDevType.Size = new System.Drawing.Size(121, 32);
            this.cbxDevType.TabIndex = 10;
            // 
            // btnDevCancel
            // 
            this.btnDevCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDevCancel.Location = new System.Drawing.Point(3, 151);
            this.btnDevCancel.Name = "btnDevCancel";
            this.btnDevCancel.Size = new System.Drawing.Size(94, 35);
            this.btnDevCancel.TabIndex = 11;
            this.btnDevCancel.Text = "取消";
            this.btnDevCancel.UseVisualStyleBackColor = true;
            this.btnDevCancel.Click += new System.EventHandler(this.btnDevCancel_Click);
            // 
            // btnDevOk
            // 
            this.btnDevOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevOk.Location = new System.Drawing.Point(103, 151);
            this.btnDevOk.Name = "btnDevOk";
            this.btnDevOk.Size = new System.Drawing.Size(288, 35);
            this.btnDevOk.TabIndex = 8;
            this.btnDevOk.Text = "确认";
            this.btnDevOk.UseVisualStyleBackColor = true;
            this.btnDevOk.Click += new System.EventHandler(this.btnDevOk_Click);
            // 
            // FrmAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加设备";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtDevIp;
        private System.Windows.Forms.Label lblDevName;
        private System.Windows.Forms.Label lblDevIp;
        private System.Windows.Forms.Label lblDevType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDevNama;
        private System.Windows.Forms.Button btnDevOk;
        private System.Windows.Forms.ComboBox cbxDevType;
        private System.Windows.Forms.Button btnDevCancel;
    }
}