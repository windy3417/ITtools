namespace ITtools.UI
{
    partial class Frm_resources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_resources));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_voucherStatus = new System.Windows.Forms.Label();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_url = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusCode = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网络地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.webURLServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.lbl_voucherStatus);
            this.panel1.Controls.Add(this.dgv_list);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 410);
            this.panel1.TabIndex = 0;
            // 
            // lbl_voucherStatus
            // 
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
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.introduction,
            this.网络地址,
            this.navigate});
            this.dgv_list.DataSource = this.webURLServiceBindingSource;
            this.dgv_list.Location = new System.Drawing.Point(3, 241);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(738, 150);
            this.dgv_list.TabIndex = 2;
            this.dgv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_list.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_customer.Location = new System.Drawing.Point(337, 32);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(120, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "互联网资源";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_url, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_cusCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_url, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_content, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_content, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_url
            // 
            this.lbl_url.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(3, 85);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(59, 12);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Tag = "客户名称标签";
            this.lbl_url.Text = "网页地址:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Tag = "网页编码标签";
            this.label2.Text = "网页编码：";
            // 
            // txt_cusCode
            // 
            this.txt_cusCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cusCode.Location = new System.Drawing.Point(111, 20);
            this.txt_cusCode.Name = "txt_cusCode";
            this.txt_cusCode.Size = new System.Drawing.Size(252, 21);
            this.txt_cusCode.TabIndex = 1;
            this.txt_cusCode.Tag = "客户编码";
            this.txt_cusCode.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
            // 
            // txt_url
            // 
            this.txt_url.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_url.Location = new System.Drawing.Point(111, 81);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(252, 21);
            this.txt_url.TabIndex = 2;
            this.txt_url.Tag = "客户名称";
            // 
            // lbl_content
            // 
            this.lbl_content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(381, 24);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(65, 12);
            this.lbl_content.TabIndex = 0;
            this.lbl_content.Tag = "网页内容标签";
            this.lbl_content.Text = "网页内容：";
            // 
            // txt_content
            // 
            this.txt_content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_content.Location = new System.Drawing.Point(477, 20);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(252, 21);
            this.txt_content.TabIndex = 1;
            this.txt_content.Tag = "内容介绍";
            this.txt_content.Validating += new System.ComponentModel.CancelEventHandler(this.regValidating);
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
            // webURLServiceBindingSource
            // 
            this.webURLServiceBindingSource.DataSource = typeof(ITtools.Services.WebURLService);
            // 
            // Frm_resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_resources";
            this.Text = "互联网资源";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_customer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_customer_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webURLServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusCode;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_abandon;
        private System.Windows.Forms.Label lbl_voucherStatus;
        private System.Windows.Forms.TextBox txt_content;

        private System.Windows.Forms.BindingSource webURLServiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网络地址;
        private System.Windows.Forms.DataGridViewButtonColumn navigate;
    }
}