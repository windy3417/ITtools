namespace ITtools.UI
{
    partial class Frm_dataBaseBac
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cmb_dataBaseList = new System.Windows.Forms.ComboBox();
            this.lbl_dataBase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_bacup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ITtools.Properties.Resources.icon_quit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "关闭";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cmb_dataBaseList
            // 
            this.cmb_dataBaseList.FormattingEnabled = true;
            this.cmb_dataBaseList.Location = new System.Drawing.Point(145, 82);
            this.cmb_dataBaseList.Name = "cmb_dataBaseList";
            this.cmb_dataBaseList.Size = new System.Drawing.Size(121, 20);
            this.cmb_dataBaseList.TabIndex = 1;
            this.cmb_dataBaseList.SelectedValueChanged += new System.EventHandler(this.cmb_dataBaseList_SelectedValueChanged);
            // 
            // lbl_dataBase
            // 
            this.lbl_dataBase.AutoSize = true;
            this.lbl_dataBase.Location = new System.Drawing.Point(93, 85);
            this.lbl_dataBase.Name = "lbl_dataBase";
            this.lbl_dataBase.Size = new System.Drawing.Size(47, 12);
            this.lbl_dataBase.TabIndex = 2;
            this.lbl_dataBase.Text = "数据库:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "备份设备：";
            // 
            // btn_bacup
            // 
            this.btn_bacup.Location = new System.Drawing.Point(553, 136);
            this.btn_bacup.Name = "btn_bacup";
            this.btn_bacup.Size = new System.Drawing.Size(75, 23);
            this.btn_bacup.TabIndex = 4;
            this.btn_bacup.Text = "备份";
            this.btn_bacup.UseVisualStyleBackColor = true;
            this.btn_bacup.Click += new System.EventHandler(this.btn_bacup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_directory
            // 
            this.txt_directory.Location = new System.Drawing.Point(454, 80);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.Size = new System.Drawing.Size(245, 21);
            this.txt_directory.TabIndex = 5;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(699, 78);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(32, 23);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "...";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Frm_dataBaseBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txt_directory);
            this.Controls.Add(this.btn_bacup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dataBase);
            this.Controls.Add(this.cmb_dataBaseList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_dataBaseBac";
            this.Text = "数据库备份";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cmb_dataBaseList;
        private System.Windows.Forms.Label lbl_dataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_bacup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}