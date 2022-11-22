namespace ITtools.UI
{
    partial class FrmImport
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
            this.DgvImport = new System.Windows.Forms.DataGridView();
            this.TsImport = new System.Windows.Forms.ToolStrip();
            this.tsmChooseFile = new System.Windows.Forms.ToolStripButton();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.cmbFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImport)).BeginInit();
            this.TsImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvImport
            // 
            this.DgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImport.Location = new System.Drawing.Point(12, 112);
            this.DgvImport.Name = "DgvImport";
            this.DgvImport.RowTemplate.Height = 23;
            this.DgvImport.Size = new System.Drawing.Size(776, 326);
            this.DgvImport.TabIndex = 0;
            // 
            // TsImport
            // 
            this.TsImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChooseFile,
            this.TsbSave,
            this.TsbClose});
            this.TsImport.Location = new System.Drawing.Point(0, 0);
            this.TsImport.Name = "TsImport";
            this.TsImport.Size = new System.Drawing.Size(800, 25);
            this.TsImport.TabIndex = 1;
            this.TsImport.Text = "toolStrip1";
            // 
            // tsmChooseFile
            // 
            this.tsmChooseFile.Image = global::ITtools.Properties.Resources.importdir_wiz;
            this.tsmChooseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmChooseFile.Name = "tsmChooseFile";
            this.tsmChooseFile.Size = new System.Drawing.Size(76, 22);
            this.tsmChooseFile.Text = "选择文件";
            this.tsmChooseFile.Click += new System.EventHandler(this.tsmChooseFile_Click);
            // 
            // TsbSave
            // 
            this.TsbSave.Image = global::ITtools.Properties.Resources.save;
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(52, 22);
            this.TsbSave.Text = "保存";
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
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
            // cmbFileName
            // 
            this.cmbFileName.FormattingEnabled = true;
            this.cmbFileName.Location = new System.Drawing.Point(71, 59);
            this.cmbFileName.Name = "cmbFileName";
            this.cmbFileName.Size = new System.Drawing.Size(121, 20);
            this.cmbFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件名：";
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFileName);
            this.Controls.Add(this.TsImport);
            this.Controls.Add(this.DgvImport);
            this.Name = "FrmImport";
            this.Text = "通用导入平台";
            ((System.ComponentModel.ISupportInitialize)(this.DgvImport)).EndInit();
            this.TsImport.ResumeLayout(false);
            this.TsImport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvImport;
        private System.Windows.Forms.ToolStrip TsImport;
        private System.Windows.Forms.ToolStripButton tsmChooseFile;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.ComboBox cmbFileName;
        private System.Windows.Forms.Label label1;
    }
}