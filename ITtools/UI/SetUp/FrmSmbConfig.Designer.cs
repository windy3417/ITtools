namespace ITtools.UI.SetUp
{
    partial class FrmSmbConfig


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
            this.TsbSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtFoldDirectory = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsbTest
            // 
            this.TsbTest.Location = new System.Drawing.Point(210, 199);
            this.TsbTest.Name = "TsbTest";
            this.TsbTest.Size = new System.Drawing.Size(50, 23);
            this.TsbTest.TabIndex = 4;
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
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbClose
            // 
            this.TsbClose.Image = global::ITtools.Properties.Resources.exit;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(53, 22);
            this.TsbClose.Text = "关闭";
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // TsbSave
            // 
            this.TsbSave.Location = new System.Drawing.Point(291, 199);
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(50, 23);
            this.TsbSave.TabIndex = 5;
            this.TsbSave.Text = "保存";
            this.TsbSave.UseVisualStyleBackColor = true;
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "文件服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "密码：";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(199, 42);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(153, 21);
            this.txtHostName.TabIndex = 0;
            // 
            // txtFoldDirectory
            // 
            this.txtFoldDirectory.Location = new System.Drawing.Point(199, 73);
            this.txtFoldDirectory.Name = "txtFoldDirectory";
            this.txtFoldDirectory.Size = new System.Drawing.Size(153, 21);
            this.txtFoldDirectory.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(199, 105);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(153, 21);
            this.txtUser.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(199, 137);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(153, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // FrmSmbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 295);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtFoldDirectory);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TsbSave);
            this.Controls.Add(this.TsbTest);
            this.Name = "FrmSmbConfig";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TsbTest;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.Button TsbSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtFoldDirectory;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
    }
}