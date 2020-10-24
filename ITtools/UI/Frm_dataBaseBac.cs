using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Utility.Sql;
using ITtools.Services;

namespace ITtools.UI
{
    public partial class Frm_dataBaseBac : Form
    {
        string directory;

        public Frm_dataBaseBac()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(closeParent);
            this.WindowState = FormWindowState.Maximized;
            initializeControlDataSource();
            
        }

        void initializeControlDataSource()
        {

            var query = from q in new DataBaseListService().dataBaseList().AsEnumerable()
                        select new { name=q.Field<String>(0)}; 
            cmb_dataBaseList.DataSource = query.ToList();
            cmb_dataBaseList.DisplayMember = "name";
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object seder,System.Windows.Forms.FormClosedEventArgs formClosedEventArgs)
        {
            this.Parent.Dispose();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                directory = folderBrowserDialog1.SelectedPath;
                txt_directory.Text = directory + "\\"+cmb_dataBaseList.Text + ".bak";
                
            } 

        }

        private void btn_bacup_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParameters = {new SqlParameter("@dataBase",cmb_dataBaseList.Text),
                                                new SqlParameter("@directory",txt_directory.Text),
           new SqlParameter("@name",cmb_dataBaseList.Text+DateTime.Now.Date.ToString("yyyyMMdd")+ DateTime.Now.TimeOfDay.ToString("hhmmss")+"FullBacup") };

            String sql = "BACKUP DATABASE @dataBase TO  DISK =@directory WITH  RETAINDAYS = 7, NOFORMAT, NOINIT,  NAME =@name, NOSKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            try
            {
                Sqlhelper.UpdateWithparameters(sql, sqlParameters);
                MessageBox.Show("数据备份成功", "数据库备份提示");            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException, "数据库备份提示");
            }
            
        }

        private void cmb_dataBaseList_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmb_dataBaseList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txt_directory.Text != "")
            {
                txt_directory.Text = directory + "\\" + cmb_dataBaseList.Text + ".bak";
            }
        }
    }
}
