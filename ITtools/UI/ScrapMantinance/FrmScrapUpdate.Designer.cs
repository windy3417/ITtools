
namespace ITtools.UI.ScrapMantinance
{
    partial class FrmScrapUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNetWeight = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.TsbUpdateNetWeight = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkinWeight = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "过磅单号：";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(107, 62);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(160, 21);
            this.txtVoucherNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "备注：";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(107, 122);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(160, 21);
            this.txtMemo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "净重：";
            // 
            // TxtNetWeight
            // 
            this.TxtNetWeight.Location = new System.Drawing.Point(107, 182);
            this.TxtNetWeight.Name = "TxtNetWeight";
            this.TxtNetWeight.Size = new System.Drawing.Size(160, 21);
            this.TxtNetWeight.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSave,
            this.TsbUpdateNetWeight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbSave
            // 
            this.TsbSave.Image = global::ITtools.Properties.Resources.save;
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(53, 22);
            this.TsbSave.Text = "保存";
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // TsbUpdateNetWeight
            // 
            this.TsbUpdateNetWeight.Image = global::ITtools.Properties.Resources.Modify;
            this.TsbUpdateNetWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUpdateNetWeight.Name = "TsbUpdateNetWeight";
            this.TsbUpdateNetWeight.Size = new System.Drawing.Size(79, 22);
            this.TsbUpdateNetWeight.Text = "修改重量";
            this.TsbUpdateNetWeight.Click += new System.EventHandler(this.TsbUpdateNetWeight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "皮重：";
            // 
            // txtSkinWeight
            // 
            this.txtSkinWeight.Location = new System.Drawing.Point(352, 122);
            this.txtSkinWeight.Name = "txtSkinWeight";
            this.txtSkinWeight.Size = new System.Drawing.Size(160, 21);
            this.txtSkinWeight.TabIndex = 1;
            // 
            // FrmScrapUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 373);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSkinWeight);
            this.Controls.Add(this.TxtNetWeight);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmScrapUpdate";
            this.Text = "过磅单修改";
            this.Load += new System.EventHandler(this.FrmScrapUpdate_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNetWeight;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton TsbUpdateNetWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkinWeight;
    }
}