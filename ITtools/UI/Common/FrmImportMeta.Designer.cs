namespace ITtools.UI
{
    partial class FrmImportMeta
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxID = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GbRecord = new System.Windows.Forms.GroupBox();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.GbRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSave,
            this.tsbQuery,
            this.tsbDelete,
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单据编码：";
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(147, 26);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(100, 21);
            this.txtVoucherCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "单据名称：";
            // 
            // txtVoucherName
            // 
            this.txtVoucherName.Location = new System.Drawing.Point(338, 26);
            this.txtVoucherName.Name = "txtVoucherName";
            this.txtVoucherName.Size = new System.Drawing.Size(100, 21);
            this.txtVoucherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "初始ID：";
            // 
            // txtMaxID
            // 
            this.txtMaxID.Location = new System.Drawing.Point(521, 26);
            this.txtMaxID.Name = "txtMaxID";
            this.txtMaxID.Size = new System.Drawing.Size(100, 21);
            this.txtMaxID.TabIndex = 4;
            // 
            // DgvList
            // 
            this.DgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Location = new System.Drawing.Point(12, 125);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowTemplate.Height = 23;
            this.DgvList.Size = new System.Drawing.Size(776, 313);
            this.DgvList.TabIndex = 3;
            // 
            // GbRecord
            // 
            this.GbRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbRecord.Controls.Add(this.txtVoucherName);
            this.GbRecord.Controls.Add(this.label1);
            this.GbRecord.Controls.Add(this.txtMaxID);
            this.GbRecord.Controls.Add(this.txtVoucherCode);
            this.GbRecord.Controls.Add(this.label3);
            this.GbRecord.Controls.Add(this.label2);
            this.GbRecord.Location = new System.Drawing.Point(12, 43);
            this.GbRecord.Name = "GbRecord";
            this.GbRecord.Size = new System.Drawing.Size(776, 64);
            this.GbRecord.TabIndex = 4;
            this.GbRecord.TabStop = false;
            this.GbRecord.Text = "信息录入";
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
            // tsbQuery
            // 
            this.tsbQuery.Image = global::ITtools.Properties.Resources.Search;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(52, 22);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
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
            // tsbDelete
            // 
            this.tsbDelete.Image = global::ITtools.Properties.Resources.DeleteRow;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删行";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // FrmImportMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbRecord);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmImportMeta";
            this.Text = "导入表单信息";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.GbRecord.ResumeLayout(false);
            this.GbRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton TsbClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoucherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxID;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.GroupBox GbRecord;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}