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
            this.RtbDecryptCharacter = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtbEncryptCharacter
            // 
            this.RtbEncryptCharacter.Location = new System.Drawing.Point(101, 61);
            this.RtbEncryptCharacter.Name = "RtbEncryptCharacter";
            this.RtbEncryptCharacter.Size = new System.Drawing.Size(577, 45);
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
            this.label1.Text = "加密字符：";
            // 
            // RtbDecryptCharacter
            // 
            this.RtbDecryptCharacter.Location = new System.Drawing.Point(101, 179);
            this.RtbDecryptCharacter.Name = "RtbDecryptCharacter";
            this.RtbDecryptCharacter.Size = new System.Drawing.Size(577, 45);
            this.RtbDecryptCharacter.TabIndex = 0;
            this.RtbDecryptCharacter.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "解密字符：";
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(359, 123);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnDecrypt.TabIndex = 2;
            this.BtnDecrypt.Text = "解密";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtbDecryptCharacter);
            this.Controls.Add(this.RtbEncryptCharacter);
            this.Name = "FrmDecrypt";
            this.Text = "解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbEncryptCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtbDecryptCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}