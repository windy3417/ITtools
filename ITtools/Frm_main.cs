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
            Frm_config frm_Config = new Frm_config();
            embedForm(frm_Config);
        }
    }
}
