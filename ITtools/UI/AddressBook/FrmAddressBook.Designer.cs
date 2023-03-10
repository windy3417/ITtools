
namespace ITtools.UI.AddressBook
{
    partial class FrmAddressBook
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
            this.TsbQuery = new System.Windows.Forms.ToolStripButton();
            this.TsbAddressBookUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbDept = new System.Windows.Forms.ComboBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmanetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbQuery,
            this.TsbAddressBookUpdate,
            this.tsbDelete,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbQuery
            // 
            this.TsbQuery.Image = global::ITtools.Properties.Resources.Search;
            this.TsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbQuery.Name = "TsbQuery";
            this.TsbQuery.Size = new System.Drawing.Size(53, 22);
            this.TsbQuery.Text = "查询";
            this.TsbQuery.Click += new System.EventHandler(this.TsbQuery_Click);
            // 
            // TsbAddressBookUpdate
            // 
            this.TsbAddressBookUpdate.Image = global::ITtools.Properties.Resources.Modify;
            this.TsbAddressBookUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAddressBookUpdate.Name = "TsbAddressBookUpdate";
            this.TsbAddressBookUpdate.Size = new System.Drawing.Size(53, 22);
            this.TsbAddressBookUpdate.Text = "修改";
            this.TsbAddressBookUpdate.Click += new System.EventHandler(this.TsbAddressBookUpdate_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ITtools.Properties.Resources.exit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "关闭";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CmbDept);
            this.groupBox1.Controls.Add(this.txtPersonName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // CmbDept
            // 
            this.CmbDept.FormattingEnabled = true;
            this.CmbDept.Location = new System.Drawing.Point(331, 39);
            this.CmbDept.Name = "CmbDept";
            this.CmbDept.Size = new System.Drawing.Size(121, 20);
            this.CmbDept.TabIndex = 2;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(94, 37);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(100, 21);
            this.txtPersonName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "部门编码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员姓名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmanetName,
            this.personName,
            this.ExNo,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 289);
            this.dataGridView1.TabIndex = 2;
            // 
            // departmanetName
            // 
            this.departmanetName.HeaderText = "部门名称";
            this.departmanetName.Name = "departmanetName";
            // 
            // personName
            // 
            this.personName.HeaderText = "人员姓名";
            this.personName.Name = "personName";
            // 
            // ExNo
            // 
            this.ExNo.HeaderText = "分机号";
            this.ExNo.Name = "ExNo";
            // 
            // email
            // 
            this.email.HeaderText = "邮箱地址";
            this.email.Name = "email";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::ITtools.Properties.Resources.DeleteRow;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(53, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // FrmAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAddressBook";
            this.Text = "通讯录";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton TsbQuery;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox CmbDept;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton TsbAddressBookUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}