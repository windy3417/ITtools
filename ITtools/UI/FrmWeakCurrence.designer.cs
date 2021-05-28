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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeakCurrence));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_voucherStatus = new System.Windows.Forms.Label();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resoucesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网络地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.tlp_record = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_url = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusCode = new System.Windows.Forms.TextBox();
            this.txtPrVoucherNo = new System.Windows.Forms.TextBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txtPrContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPrDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbdSettleDate = new Utility.UControl.txtBoxWithDate();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.webURLServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.tlp_record.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_voucherStatus);
            this.panel1.Controls.Add(this.dgv_list);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.tlp_record);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 410);
            this.panel1.TabIndex = 0;
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
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.AutoGenerateColumns = false;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.resoucesType,
            this.introduction,
            this.网络地址,
            this.navigate});
            this.dgv_list.DataSource = this.webURLServiceBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_list.Location = new System.Drawing.Point(3, 241);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(738, 150);
            this.dgv_list.TabIndex = 2;
            this.dgv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellContentClick);
            this.dgv_list.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.FillWeight = 50.76142F;
            this.id.Frozen = true;
            this.id.HeaderText = "资源编码";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // resoucesType
            // 
            this.resoucesType.DataPropertyName = "value";
            this.resoucesType.HeaderText = "类型";
            this.resoucesType.Name = "resoucesType";
            this.resoucesType.ReadOnly = true;
            // 
            // introduction
            // 
            this.introduction.DataPropertyName = "introduction";
            this.introduction.FillWeight = 149.2386F;
            this.introduction.HeaderText = "网页内容";
            this.introduction.Name = "introduction";
            this.introduction.ReadOnly = true;
            // 
            // 网络地址
            // 
            this.网络地址.DataPropertyName = "url";
            this.网络地址.HeaderText = "网络地址";
            this.网络地址.Name = "网络地址";
            this.网络地址.ReadOnly = true;
            // 
            // navigate
            // 
            this.navigate.HeaderText = "阅览";
            this.navigate.Name = "navigate";
            this.navigate.ReadOnly = true;
            this.navigate.Text = "阅览";
            this.navigate.UseColumnTextForButtonValue = true;
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
            // tlp_record
            // 
            this.tlp_record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_record.ColumnCount = 6;
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09134F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.83469F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.82114F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.7832F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.33062F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.66125F));
            this.tlp_record.Controls.Add(this.lbl_url, 0, 1);
            this.tlp_record.Controls.Add(this.label2, 0, 0);
            this.tlp_record.Controls.Add(this.txt_cusCode, 1, 0);
            this.tlp_record.Controls.Add(this.txtPrVoucherNo, 1, 1);
            this.tlp_record.Controls.Add(this.lbl_content, 0, 2);
            this.tlp_record.Controls.Add(this.txtPrContent, 1, 2);
            this.tlp_record.Controls.Add(this.label1, 2, 0);
            this.tlp_record.Controls.Add(this.txbPrPerson, 3, 0);
            this.tlp_record.Controls.Add(this.label3, 4, 0);
            this.tlp_record.Controls.Add(this.dtpPrDate, 5, 0);
            this.tlp_record.Controls.Add(this.label4, 4, 1);
            this.tlp_record.Controls.Add(this.checkBox1, 3, 1);
            this.tlp_record.Controls.Add(this.tbdSettleDate, 5, 1);
            this.tlp_record.Controls.Add(this.label5, 2, 1);
            this.tlp_record.Location = new System.Drawing.Point(3, 70);
            this.tlp_record.Name = "tlp_record";
            this.tlp_record.RowCount = 3;
            this.tlp_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_record.Size = new System.Drawing.Size(738, 122);
            this.tlp_record.TabIndex = 0;
            // 
            // lbl_url
            // 
            this.lbl_url.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(13, 52);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(65, 12);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Tag = "客户名称标签";
            this.lbl_url.Text = "请购单号：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Tag = "网页编码标签";
            this.label2.Text = "工程编码：";
            // 
            // txt_cusCode
            // 
            this.txt_cusCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cusCode.Location = new System.Drawing.Point(84, 9);
            this.txt_cusCode.Name = "txt_cusCode";
            this.txt_cusCode.Size = new System.Drawing.Size(132, 21);
            this.txt_cusCode.TabIndex = 1;
            this.txt_cusCode.Tag = "客户编码";
            this.txt_cusCode.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // txtPrVoucherNo
            // 
            this.txtPrVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrVoucherNo.Location = new System.Drawing.Point(84, 48);
            this.txtPrVoucherNo.Name = "txtPrVoucherNo";
            this.txtPrVoucherNo.Size = new System.Drawing.Size(132, 21);
            this.txtPrVoucherNo.TabIndex = 3;
            this.txtPrVoucherNo.Tag = "客户名称";
            // 
            // lbl_content
            // 
            this.lbl_content.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(13, 94);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(65, 12);
            this.lbl_content.TabIndex = 0;
            this.lbl_content.Tag = "网页内容标签";
            this.lbl_content.Text = "请购内容：";
            // 
            // txtPrContent
            // 
            this.txtPrContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlp_record.SetColumnSpan(this.txtPrContent, 5);
            this.txtPrContent.Location = new System.Drawing.Point(84, 89);
            this.txtPrContent.Name = "txtPrContent";
            this.txtPrContent.Size = new System.Drawing.Size(643, 21);
            this.txtPrContent.TabIndex = 4;
            this.txtPrContent.Tag = "内容介绍";
            this.txtPrContent.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "客户名称标签";
            this.label1.Text = "请购人员:";
            // 
            // txbPrPerson
            // 
            this.txbPrPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbPrPerson.Location = new System.Drawing.Point(323, 9);
            this.txbPrPerson.Name = "txbPrPerson";
            this.txbPrPerson.Size = new System.Drawing.Size(133, 21);
            this.txbPrPerson.TabIndex = 3;
            this.txbPrPerson.Tag = "客户名称";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Tag = "客户名称标签";
            this.label3.Text = "请购日期:";
            // 
            // dtpPrDate
            // 
            this.dtpPrDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpPrDate.Location = new System.Drawing.Point(558, 9);
            this.dtpPrDate.Name = "dtpPrDate";
            this.dtpPrDate.Size = new System.Drawing.Size(169, 21);
            this.dtpPrDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Tag = "网页内容标签";
            this.label4.Text = "结算日期:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(323, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbdSettleDate
            // 
            this.tbdSettleDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbdSettleDate.Location = new System.Drawing.Point(558, 48);
            this.tbdSettleDate.Name = "tbdSettleDate";
            this.tbdSettleDate.Size = new System.Drawing.Size(169, 21);
            this.tbdSettleDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Tag = "客户名称标签";
            this.label5.Text = " 结算与否:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_abandon,
            this.tsb_save,
            this.tsb_modify,
            this.tsb_query,
            this.tsb_delete,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(52, 22);
            this.tsb_add.Text = "增加";
            this.tsb_add.Click += new System.EventHandler(this.Tsb_add_Click);
            // 
            // tsb_abandon
            // 
            this.tsb_abandon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abandon.Image")));
            this.tsb_abandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abandon.Name = "tsb_abandon";
            this.tsb_abandon.Size = new System.Drawing.Size(52, 22);
            this.tsb_abandon.Text = "放弃";
            this.tsb_abandon.Click += new System.EventHandler(this.Tsb_abandon_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
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
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
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
            // FrmWeakCurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.tlp_record.ResumeLayout(false);
            this.tlp_record.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tlp_record;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusCode;
        private System.Windows.Forms.TextBox txtPrVoucherNo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.DataGridView dgv_list;

        public System.Windows.Forms.ToolStripButton tsb_modify;

        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_abandon;
        private System.Windows.Forms.Label lbl_voucherStatus;
        private System.Windows.Forms.TextBox txtPrContent;

        private System.Windows.Forms.BindingSource webURLServiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn resoucesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网络地址;
        private System.Windows.Forms.DataGridViewButtonColumn navigate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPrDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private Utility.UControl.txtBoxWithDate tbdSettleDate;
        private System.Windows.Forms.Label label5;
    }
}