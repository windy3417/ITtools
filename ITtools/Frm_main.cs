using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using Utility.UI;
using ITtools.UI;

namespace ITtools
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void 数据库备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_dataBaseBac frm_DataBaseBac = new Frm_dataBaseBac();
            embedForm(frm_DataBaseBac);
        }

        private void embedForm(Form form)
        {
            EmbedForm embedForm = new EmbedForm();
            
            embedForm.openForm(form, form.Text, tabControl1, panel1);
        }

        private void 文件夹备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 数据库设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_itDouble_DB_config f = new Frm_itDouble_DB_config();
            embedForm(f);
        }

        private void 常用备份路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_directory frm_DirectoryBac = new Frm_directory();
            embedForm(frm_DirectoryBac);
        }

        private void 互联网资源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_resources f = new Frm_resources();
            embedForm(f);
        }

        private void 删除文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_fileDelete f = new Frm_fileDelete();
            embedForm(f);
        }

        private void 资源列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_resourcesList f = new Frm_resourcesList();
            embedForm(f);
        }
    }
}
