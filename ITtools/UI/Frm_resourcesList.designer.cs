namespace ITtools.UI
{
    partial class Frm_resourcesList

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_resourcesList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resoucesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网络地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.tlp_record = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_class = new System.Windows.Forms.Label();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsb_export = new System.Windows.Forms.ToolStripButton();
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
            this.panel1.Controls.Add(this.dgv_list);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.tlp_record);
            this.panel1.Location = new System.Drawing.Point(34, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 410);
            this.panel1.TabIndex = 0;
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
            this.dgv_list.Location = new System.Drawing.Point(33, 141);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(738, 221);
            this.dgv_list.TabIndex = 2;
            this.dgv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellContentClick);
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
            this.lbl_customer.Location = new System.Drawing.Point(338, 19);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(134, 21);
            this.lbl_customer.TabIndex = 1;
            this.lbl_customer.Text = "资 源 列 表";
            // 
            // tlp_record
            // 
            this.tlp_record.ColumnCount = 4;
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlp_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tlp_record.Controls.Add(this.lbl_class, 0, 0);
            this.tlp_record.Controls.Add(this.cmb_class, 1, 0);
            this.tlp_record.Controls.Add(this.lbl_content, 2, 0);
            this.tlp_record.Controls.Add(this.txt_content, 3, 0);
            this.tlp_record.Location = new System.Drawing.Point(36, 73);
            this.tlp_record.Name = "tlp_record";
            this.tlp_record.RowCount = 1;
            this.tlp_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_record.Size = new System.Drawing.Size(738, 35);
            this.tlp_record.TabIndex = 0;
            // 
            // lbl_class
            // 
            this.lbl_class.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(3, 11);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(41, 12);
            this.lbl_class.TabIndex = 0;
            this.lbl_class.Tag = "网页内容标签";
            this.lbl_class.Text = "类型：";
            // 
            // cmb_class
            // 
            this.cmb_class.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(111, 7);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(252, 20);
            this.cmb_class.TabIndex = 3;
            this.cmb_class.Tag = "资源类型";
            // 
            // lbl_content
            // 
            this.lbl_content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(381, 11);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(65, 12);
            this.lbl_content.TabIndex = 0;
            this.lbl_content.Tag = "网页内容标签";
            this.lbl_content.Text = "网页内容：";
            // 
            // txt_content
            // 
            this.txt_content.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_content.Location = new System.Drawing.Point(477, 7);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(252, 21);
            this.txt_content.TabIndex = 1;
            this.txt_content.Tag = "内容介绍";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_query,
            this.tsb_close,
            this.tsb_export});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_query
            // 
            this.tsb_query.Image = global::ITtools.Properties.Resources.预览;
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
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
            // tsb_export
            // 
            this.tsb_export.Image = global::ITtools.Properties.Resources.export;
            this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_export.Name = "tsb_export";
            this.tsb_export.Size = new System.Drawing.Size(52, 22);
            this.tsb_export.Text = "导出";
            this.tsb_export.Click += new System.EventHandler(this.tsb_export_Click);
            // 
            // webURLServiceBindingSource
            // 
            this.webURLServiceBindingSource.DataSource = typeof(ITtools.Services.WebURLService);
            // 
            // Frm_resourcesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_resourcesList";
            this.Text = "资源列表";
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.TextBox txt_content;

        private System.Windows.Forms.BindingSource webURLServiceBindingSource;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn resoucesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网络地址;
        private System.Windows.Forms.DataGridViewButtonColumn navigate;
        private System.Windows.Forms.ToolStripButton tsb_export;
    }
}