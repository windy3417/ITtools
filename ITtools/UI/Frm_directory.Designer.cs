namespace ITtools.UI
{
    partial class Frm_directory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_openFileDirectory = new System.Windows.Forms.Button();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dierctoryID = new System.Windows.Forms.TextBox();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_close,
            this.tsb_add,
            this.tsb_save,
            this.tsb_query});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.68132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58741F));
            this.tableLayoutPanel1.Controls.Add(this.btn_openFileDirectory, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_item, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_dierctoryID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_directory, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(197, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_openFileDirectory
            // 
            this.btn_openFileDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_openFileDirectory.Location = new System.Drawing.Point(318, 64);
            this.btn_openFileDirectory.Name = "btn_openFileDirectory";
            this.btn_openFileDirectory.Size = new System.Drawing.Size(35, 21);
            this.btn_openFileDirectory.TabIndex = 4;
            this.btn_openFileDirectory.Text = "...";
            this.btn_openFileDirectory.UseVisualStyleBackColor = true;
            this.btn_openFileDirectory.Click += new System.EventHandler(this.btn_openFileDirectory_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(3, 19);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(41, 12);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "编号：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "路径：";
            // 
            // txt_dierctoryID
            // 
            this.txt_dierctoryID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_dierctoryID.Location = new System.Drawing.Point(70, 14);
            this.txt_dierctoryID.Name = "txt_dierctoryID";
            this.txt_dierctoryID.Size = new System.Drawing.Size(242, 21);
            this.txt_dierctoryID.TabIndex = 1;
            // 
            // txt_directory
            // 
            this.txt_directory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_directory.Location = new System.Drawing.Point(70, 64);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.Size = new System.Drawing.Size(242, 21);
            this.txt_directory.TabIndex = 1;
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(197, 231);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.Size = new System.Drawing.Size(362, 150);
            this.dgv_list.TabIndex = 2;
            // 
            // lbl_titel
            // 
            this.lbl_titel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(317, 50);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(184, 19);
            this.lbl_titel.TabIndex = 3;
            this.lbl_titel.Text = "常 用 备 份 路 径";
            // 
            // tsb_close
            // 
            this.tsb_close.Image = global::ITtools.Properties.Resources.icon_quit;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add.Image = global::ITtools.Properties.Resources.add;
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(23, 22);
            this.tsb_add.Text = "增加";
            // 
            // tsb_save
            // 
            this.tsb_save.Image = global::ITtools.Properties.Resources.save;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(52, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = global::ITtools.Properties.Resources.Search;
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // Frm_directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_titel);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_directory";
            this.Text = "常用备份路径";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_openFileDirectory;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dierctoryID;
        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_query;
    }
}