namespace ITtools.UI
{
    partial class FrmWeakCurrence

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeakCurrence));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRecordRegion = new System.Windows.Forms.Panel();
            this.txtPrVoucherNo = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.dtpPrDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txbPrPerson = new System.Windows.Forms.TextBox();
            this.lbl_voucherStatus = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRef = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsbSettle = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.webURLServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAuditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settleFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pRecordRegion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pRecordRegion);
            this.panel1.Controls.Add(this.lbl_voucherStatus);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 410);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccode,
            this.dDate,
            this.cAuditDate,
            this.cPersonName,
            this.cInvCode,
            this.cInvName,
            this.cInvStd,
            this.settleFlag,
            this.settleDate,
            this.IsClose});
            this.dataGridView1.Location = new System.Drawing.Point(33, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(738, 241);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // pRecordRegion
            // 
            this.pRecordRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pRecordRegion.Controls.Add(this.txtPrVoucherNo);
            this.pRecordRegion.Controls.Add(this.lbl_url);
            this.pRecordRegion.Controls.Add(this.dtpPrDate);
            this.pRecordRegion.Controls.Add(this.label1);
            this.pRecordRegion.Controls.Add(this.txtPrContent);
            this.pRecordRegion.Controls.Add(this.label3);
            this.pRecordRegion.Controls.Add(this.lbl_content);
            this.pRecordRegion.Controls.Add(this.txbPrPerson);
            this.pRecordRegion.Location = new System.Drawing.Point(3, 56);
            this.pRecordRegion.Name = "pRecordRegion";
            this.pRecordRegion.Size = new System.Drawing.Size(741, 90);
            this.pRecordRegion.TabIndex = 6;
            // 
            // txtPrVoucherNo
            // 
            this.txtPrVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrVoucherNo.Location = new System.Drawing.Point(103, 20);
            this.txtPrVoucherNo.Name = "txtPrVoucherNo";
            this.txtPrVoucherNo.Size = new System.Drawing.Size(132, 21);
            this.txtPrVoucherNo.TabIndex = 3;
            this.txtPrVoucherNo.Tag = "客户名称";
            // 
            // lbl_url
            // 
            this.lbl_url.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(25, 23);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(65, 12);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Tag = "客户名称标签";
            this.lbl_url.Text = "请购单号：";
            // 
            // dtpPrDate
            // 
            this.dtpPrDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpPrDate.Location = new System.Drawing.Point(586, 20);
            this.dtpPrDate.Name = "dtpPrDate";
            this.dtpPrDate.Size = new System.Drawing.Size(125, 21);
            this.dtpPrDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "请购人员：";
            // 
            // txtPrContent
            // 
            this.txtPrContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrContent.Location = new System.Drawing.Point(103, 60);
            this.txtPrContent.Name = "txtPrContent";
            this.txtPrContent.Size = new System.Drawing.Size(608, 21);
            this.txtPrContent.TabIndex = 4;
            this.txtPrContent.Tag = "内容介绍";
            this.txtPrContent.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Tag = "客户名称标签";
            this.label3.Text = "请购日期:";
            // 
            // lbl_content
            // 
            this.lbl_content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(25, 65);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(65, 12);
            this.lbl_content.TabIndex = 0;
            this.lbl_content.Tag = "网页内容标签";
            this.lbl_content.Text = "请购内容：";
            // 
            // txbPrPerson
            // 
            this.txbPrPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPrPerson.Location = new System.Drawing.Point(334, 20);
            this.txbPrPerson.Name = "txbPrPerson";
            this.txbPrPerson.Size = new System.Drawing.Size(138, 21);
            this.txbPrPerson.TabIndex = 3;
            this.txbPrPerson.Tag = "客户名称";
            // 
            // lbl_voucherStatus
            // 
            this.lbl_voucherStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_voucherStatus.AutoSize = true;
            this.lbl_voucherStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_voucherStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_voucherStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_voucherStatus.Location = new System.Drawing.Point(642, 4);
            this.lbl_voucherStatus.Name = "lbl_voucherStatus";
            this.lbl_voucherStatus.Size = new System.Drawing.Size(72, 14);
            this.lbl_voucherStatus.TabIndex = 3;
            this.lbl_voucherStatus.Text = "档案状态：";
            // 
            // lbl_customer
            // 
            this.lbl_customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(313, 32);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(142, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "弱电工程登记";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRef,
            this.tsb_save,
            this.tsb_modify,
            this.tsb_query,
            this.tsbSettle,
            this.tsbCancel,
            this.tsb_delete,
            this.tsbExport,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRef
            // 
            this.tsbRef.Image = global::ITtools.Properties.Resources.add;
            this.tsbRef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRef.Name = "tsbRef";
            this.tsbRef.Size = new System.Drawing.Size(52, 22);
            this.tsbRef.Text = "参照";
            this.tsbRef.Click += new System.EventHandler(this.tsbRef_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(52, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.Tsb_save_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(52, 22);
            this.tsb_modify.Text = "修改";
            this.tsb_modify.Click += new System.EventHandler(this.Tsb_modify_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsbSettle
            // 
            this.tsbSettle.Image = global::ITtools.Properties.Resources.settleaccounts;
            this.tsbSettle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettle.Name = "tsbSettle";
            this.tsbSettle.Size = new System.Drawing.Size(76, 22);
            this.tsbSettle.Text = "验收结算";
            this.tsbSettle.Click += new System.EventHandler(this.tsbSettle_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::ITtools.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(88, 22);
            this.tsbExport.Text = "输出EXCEL";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = global::ITtools.Properties.Resources.giveUpAudit;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(76, 22);
            this.tsbCancel.Text = "撤销验收";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // webURLServiceBindingSource
            // 
            this.webURLServiceBindingSource.DataSource = typeof(ITtools.Services.WebURLService);
            // 
            // ccode
            // 
            this.ccode.DataPropertyName = "ccode";
            this.ccode.HeaderText = "请购单号";
            this.ccode.Name = "ccode";
            // 
            // dDate
            // 
            this.dDate.DataPropertyName = "dDate";
            this.dDate.HeaderText = "请购日期";
            this.dDate.Name = "dDate";
            // 
            // cAuditDate
            // 
            this.cAuditDate.DataPropertyName = "cAuditDate";
            this.cAuditDate.HeaderText = "审核日期";
            this.cAuditDate.Name = "cAuditDate";
            // 
            // cPersonName
            // 
            this.cPersonName.DataPropertyName = "cPersonName";
            this.cPersonName.HeaderText = "请购人员";
            this.cPersonName.Name = "cPersonName";
            // 
            // cInvCode
            // 
            this.cInvCode.DataPropertyName = "cInvCode";
            this.cInvCode.HeaderText = "服务编码";
            this.cInvCode.Name = "cInvCode";
            // 
            // cInvName
            // 
            this.cInvName.DataPropertyName = "cInvName";
            this.cInvName.HeaderText = "服务名称";
            this.cInvName.Name = "cInvName";
            // 
            // cInvStd
            // 
            this.cInvStd.DataPropertyName = "cInvStd";
            this.cInvStd.HeaderText = "服务描述";
            this.cInvStd.Name = "cInvStd";
            // 
            // settleFlag
            // 
            this.settleFlag.DataPropertyName = "settleFlag";
            this.settleFlag.HeaderText = "是否验收";
            this.settleFlag.Name = "settleFlag";
            // 
            // settleDate
            // 
            this.settleDate.DataPropertyName = "settleDate";
            this.settleDate.HeaderText = "验收日期";
            this.settleDate.Name = "settleDate";
            // 
            // IsClose
            // 
            this.IsClose.DataPropertyName = "IsClose";
            this.IsClose.HeaderText = "关闭人";
            this.IsClose.Name = "IsClose";
            // 
            // FrmWeakCurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmWeakCurrence";
            this.Text = "弱电工程备忘";
            this.Shown += new System.EventHandler(this.FrmWeakCurrence_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_customer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_customer_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pRecordRegion.ResumeLayout(false);
            this.pRecordRegion.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox txtPrVoucherNo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_content;

        public System.Windows.Forms.ToolStripButton tsb_modify;

        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.Label lbl_voucherStatus;
        private System.Windows.Forms.TextBox txtPrContent;

        private System.Windows.Forms.BindingSource webURLServiceBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPrDate;
        private System.Windows.Forms.ToolStripButton tsbRef;
        private System.Windows.Forms.Panel pRecordRegion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsbSettle;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAuditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn settleFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn settleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsClose;
    }
}