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
    public partial class FrmMain : Form
    {
        public FrmMain()
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
            FrmConfig f = new FrmConfig();
            embedForm(f);
        }

        private void 常用备份路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_directory frm_DirectoryBac = new Frm_directory();
            embedForm(frm_DirectoryBac);
        }

        private void 互联网资源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInternetResource f = new FrmInternetResource();
            embedForm(f);
        }

        private void 删除文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFileDelete f = new FrmFileDelete();
            embedForm(f);
        }

        private void 资源列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryResources f = new FrmQueryResources();
            embedForm(f);
        }

        private void TsmCompress_Click(object sender, EventArgs e)
        {
            FrmCompress f = new FrmCompress();
            embedForm(f);
        }

        private void TsbDecrypt_Click(object sender, EventArgs e)
        {
            FrmDecrypt f = new FrmDecrypt();
            embedForm(f);
        }

        private void TsmImportData_Click(object sender, EventArgs e)
        {
            FrmImport f = new FrmImport();
            embedForm(f);
        }

        private void tsmImportDefinite_Click(object sender, EventArgs e)
        {
            FrmImportMeta f = new FrmImportMeta();
            embedForm(f);
        }

        private void tsmVersionInformation_Click(object sender, EventArgs e)
        {
            FrmVersion f = new FrmVersion();
            f.ShowDialog();
        }

        private void tsmProjectRegister_Click(object sender, EventArgs e)
        {
            FrmWeakCurrence f = new FrmWeakCurrence();
            embedForm(f);
        }
    }
}
