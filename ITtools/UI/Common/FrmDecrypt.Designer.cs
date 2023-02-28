namespace ITtools.UI
{
    partial class FrmDecrypt
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
            this.RtbEncryptCharacter = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEncrypt = new System.Windows.Forms.ToolStripButton();
            this.tsbDecrypt = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbByteToChar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtbEncryptCharacter
            // 
            this.RtbEncryptCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbEncryptCharacter.Location = new System.Drawing.Point(101, 61);
            this.RtbEncryptCharacter.Name = "RtbEncryptCharacter";
            this.RtbEncryptCharacter.Size = new System.Drawing.Size(630, 86);
            this.RtbEncryptCharacter.TabIndex = 0;
            this.RtbEncryptCharacter.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入字符：";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(101, 179);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(630, 94);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出字符：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEncrypt,
            this.tsbDecrypt,
            this.tsbByteToChar,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEncrypt
            // 
            this.tsbEncrypt.Image = global::ITtools.Properties.Resources.LoginForm_password_hi;
            this.tsbEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEncrypt.Name = "tsbEncrypt";
            this.tsbEncrypt.Size = new System.Drawing.Size(53, 22);
            this.tsbEncrypt.Text = "加密";
            this.tsbEncrypt.Click += new System.EventHandler(this.tsbEncrypt_Click);
            // 
            // tsbDecrypt
            // 
            this.tsbDecrypt.Image = global::ITtools.Properties.Resources.Key;
            this.tsbDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDecrypt.Name = "tsbDecrypt";
            this.tsbDecrypt.Size = new System.Drawing.Size(53, 22);
            this.tsbDecrypt.Text = "解密";
            this.tsbDecrypt.Click += new System.EventHandler(this.tsbDecrypt_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = global::ITtools.Properties.Resources.icon_quit;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "关闭";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsbByteToChar
            // 
            this.tsbByteToChar.Image = global::ITtools.Properties.Resources.transfer;
            this.tsbByteToChar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbByteToChar.Name = "tsbByteToChar";
            this.tsbByteToChar.Size = new System.Drawing.Size(89, 22);
            this.tsbByteToChar.Text = "Byte转字符";
            this.tsbByteToChar.Click += new System.EventHandler(this.tsbByteToChar_Click);
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.RtbEncryptCharacter);
            this.Name = "FrmDecrypt";
            this.Text = "加密解密";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbEncryptCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbEncrypt;
        private System.Windows.Forms.ToolStripButton tsbDecrypt;
        private System.Windows.Forms.ToolStripButton tsbByteToChar;
    }
}