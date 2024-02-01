using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITtools.UI.ScrapMantinance;
using Utility.UI;
using Utility.UI.Authority;
using ITtools.UI;
using ITtools.UI.U8mantinance;
using ITtools.UI.AddressBook;
using ITtools.UI.Tools;
using ITtools.UI.SetUp;
using ITtools.UI.BoxCode;

namespace ITtools
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// open form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemClick(object sender, EventArgs e)
        {

            ToolStripItem toolStripItem = (ToolStripItem)sender;
            // Instantiate the form using reflection
            Type formType = Type.GetType(toolStripItem.Tag.ToString());
            Form form = (Form)Activator.CreateInstance(formType);

            string tabPageText = form.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(form, tabPageText, tabControl1, false);

        }

        /// <summary>
        /// custom header of tabpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            Utility.Style.TabControlStyle tabControlStyle = new Utility.Style.TabControlStyle();
            tabControlStyle.TabControlDrawItem(tabControl1, e);

        }

        /// <summary>
        /// close child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Utility.Style.CloseChildForm close = new Utility.Style.CloseChildForm();
            close.Close(tabControl1, e);
        }

        private void 数据库备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_dataBaseBac frm_DataBaseBac = new Frm_dataBaseBac();
            embedForm(frm_DataBaseBac);
        }

        #region internal method


        private void embedForm(Form form)
        {
            EmbedForm embedForm = new EmbedForm();

            embedForm.openForm(form, form.Text, tabControl1, panel1);
        }

        #endregion

        #region menu handle

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
            FrmDirectory frm_DirectoryBac = new FrmDirectory();
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

        private void tsmVocherDigestModify_Click(object sender, EventArgs e)
        {
            FrmGlvouch f = new FrmGlvouch();
            embedForm(f);
        }

        private void person_Click(object sender, EventArgs e)
        {
            FrmPerson f = new FrmPerson();
            embedForm(f);
        }

        private void tsmWeightUpdate_Click(object sender, EventArgs e)
        {
            FrmScrapList f = new FrmScrapList();
            embedForm(f);
        }

        private void TsmQueryAddressBook_Click(object sender, EventArgs e)
        {
            FrmAddressBook f = new FrmAddressBook();
            embedForm(f);
        }

        private void TsmDepartment_Click(object sender, EventArgs e)
        {

            FrmDepartment f = new FrmDepartment();
            embedForm(f);
        }

        private void TsmAddressBookAdd_Click(object sender, EventArgs e)
        {
            FrmAddUpdateAddresBook f = new FrmAddUpdateAddresBook();
            embedForm(f);
        }

        #endregion

        private void tsmDownLoad_Click(object sender, EventArgs e)
        {
            FrmDownload f = new FrmDownload();
            embedForm(f);
        }

        private void tsmSmbConnectiongString_Click(object sender, EventArgs e)
        {
            FrmSmbConfig f = new FrmSmbConfig();
            embedForm(f);
        }

        private void 装箱单修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBoxCodeList f = new FrmBoxCodeList();
            embedForm(f);
        }

       
    }
    }

