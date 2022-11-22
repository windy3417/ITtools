namespace ITtools.UI
{
    partial class FrmVersion
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
            this.Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(18, 16);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(319, 226);
            this.Content.TabIndex = 0;
            this.Content.Text = "";
            // 
            // FrmVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 264);
            this.Controls.Add(this.Content);
            this.Name = "FrmVersion";
            this.Text = "版本信息";
            this.Load += new System.EventHandler(this.FrmVersion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Content;
    }
}