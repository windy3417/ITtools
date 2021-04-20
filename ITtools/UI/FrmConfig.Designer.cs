namespace ITtools.UI
{
    partial class FrmConfig
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
            this.TsbTest = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TsbSave = new System.Windows.Forms.Button();
            this.dbConnectControl1 = new Utility.UControl.DbConnectControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsbTest
            // 
            this.TsbTest.Location = new System.Drawing.Point(98, 177);
            this.TsbTest.Name = "TsbTest";
            this.TsbTest.Size = new System.Drawing.Size(52, 23);
            this.TsbTest.TabIndex = 1;
            this.TsbTest.Text = "测试";
            this.TsbTest.UseVisualStyleBackColor = true;
            this.TsbTest.Click += new System.EventHandler(this.TsbTest_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbClose
            // 
            this.TsbClose.Image = global::ITtools.Properties.Resources.exit;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(52, 22);
            this.TsbClose.Text = "关闭";
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TsbSave);
            this.groupBox1.Controls.Add(this.dbConnectControl1);
            this.groupBox1.Controls.Add(this.TsbTest);
            this.groupBox1.Location = new System.Drawing.Point(50, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IT数据库配置";
            // 
            // TsbSave
            // 
            this.TsbSave.Location = new System.Drawing.Point(177, 177);
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(50, 23);
            this.TsbSave.TabIndex = 4;
            this.TsbSave.Text = "保存";
            this.TsbSave.UseVisualStyleBackColor = true;
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // dbConnectControl1
            // 
            this.dbConnectControl1.Location = new System.Drawing.Point(24, 20);
            this.dbConnectControl1.Name = "dbConnectControl1";
            this.dbConnectControl1.Size = new System.Drawing.Size(236, 151);
            this.dbConnectControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "配置状态：";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(96, 218);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 12);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "未配置：";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmConfig";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.UControl.DbConnectControl dbConnectControl1;
        private System.Windows.Forms.Button TsbTest;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TsbSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}