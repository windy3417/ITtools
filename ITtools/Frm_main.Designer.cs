namespace ITtools
{
    partial class Frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件夹备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资源搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.互联网资源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常用备份路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.资源列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据备份ToolStripMenuItem,
            this.资源搜索ToolStripMenuItem,
            this.基础设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据备份ToolStripMenuItem
            // 
            this.数据备份ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库备份ToolStripMenuItem,
            this.文件夹备份ToolStripMenuItem,
            this.删除文件ToolStripMenuItem});
            this.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem";
            this.数据备份ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据备份ToolStripMenuItem.Text = "数据管理";
            // 
            // 数据库备份ToolStripMenuItem
            // 
            this.数据库备份ToolStripMenuItem.Name = "数据库备份ToolStripMenuItem";
            this.数据库备份ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据库备份ToolStripMenuItem.Text = "数据库备份";
            this.数据库备份ToolStripMenuItem.Click += new System.EventHandler(this.数据库备份ToolStripMenuItem_Click);
            // 
            // 文件夹备份ToolStripMenuItem
            // 
            this.文件夹备份ToolStripMenuItem.Name = "文件夹备份ToolStripMenuItem";
            this.文件夹备份ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.文件夹备份ToolStripMenuItem.Text = "文件夹备份";
            this.文件夹备份ToolStripMenuItem.Click += new System.EventHandler(this.文件夹备份ToolStripMenuItem_Click);
            // 
            // 删除文件ToolStripMenuItem
            // 
            this.删除文件ToolStripMenuItem.Name = "删除文件ToolStripMenuItem";
            this.删除文件ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除文件ToolStripMenuItem.Text = "删除文件";
            this.删除文件ToolStripMenuItem.Click += new System.EventHandler(this.删除文件ToolStripMenuItem_Click);
            // 
            // 资源搜索ToolStripMenuItem
            // 
            this.资源搜索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.互联网资源ToolStripMenuItem,
            this.资源列表ToolStripMenuItem});
            this.资源搜索ToolStripMenuItem.Name = "资源搜索ToolStripMenuItem";
            this.资源搜索ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.资源搜索ToolStripMenuItem.Text = "资源搜索";
            // 
            // 互联网资源ToolStripMenuItem
            // 
            this.互联网资源ToolStripMenuItem.Name = "互联网资源ToolStripMenuItem";
            this.互联网资源ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.互联网资源ToolStripMenuItem.Text = "资源录入";
            this.互联网资源ToolStripMenuItem.Click += new System.EventHandler(this.互联网资源ToolStripMenuItem_Click);
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库设置ToolStripMenuItem,
            this.常用备份路径ToolStripMenuItem});
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // 数据库设置ToolStripMenuItem
            // 
            this.数据库设置ToolStripMenuItem.Name = "数据库设置ToolStripMenuItem";
            this.数据库设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.数据库设置ToolStripMenuItem.Text = "数据库设置";
            this.数据库设置ToolStripMenuItem.Click += new System.EventHandler(this.数据库设置ToolStripMenuItem_Click);
            // 
            // 常用备份路径ToolStripMenuItem
            // 
            this.常用备份路径ToolStripMenuItem.Name = "常用备份路径ToolStripMenuItem";
            this.常用备份路径ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.常用备份路径ToolStripMenuItem.Text = "常用备份路径";
            this.常用备份路径ToolStripMenuItem.Click += new System.EventHandler(this.常用备份路径ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // 资源列表ToolStripMenuItem
            // 
            this.资源列表ToolStripMenuItem.Name = "资源列表ToolStripMenuItem";
            this.资源列表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.资源列表ToolStripMenuItem.Text = "资源列表";
            this.资源列表ToolStripMenuItem.Click += new System.EventHandler(this.资源列表ToolStripMenuItem_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.Text = "IT工具包";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件夹备份ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常用备份路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资源搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 互联网资源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资源列表ToolStripMenuItem;
    }
}

