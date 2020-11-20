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
using Newtonsoft;
using Newtonsoft.Json;
using Utility.Sql;
using ITtools.Services;
using ITtools.DAL;
using ITtools.Modle;

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

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        void initializeControlDataSource()
        {
            //初始化数据库数据源
            var query = from q in new DataBaseListService().dataBaseList().AsEnumerable()
                        select new { name=q.Field<String>(0)}; 
            cmb_dataBaseList.DataSource = query.ToList();
            cmb_dataBaseList.DisplayMember = "name";

            //初始化常用备分设备
            //DiretoryModle diretoryModle = new DiretoryModle();
            //List<DiretoryModle> diretoryList=new List<DiretoryModle>();
            string  jsonString = new DiretoryService().getDiretoryItem();

            string jstring = @"{direcoty:'D:\temp'}";
            //List<DiretoryItemModle> diretoryList = JsonConvert.DeserializeObject<List<DiretoryItemModle>>(jsonString);
            //List<DiretoryModle> diretoryList = JsonConvert.DeserializeObject<List<DiretoryModle>>(jstring);
            //cmb_devices.DataSource = diretoryList;
            //while (jsonReader.Read())
            //{
            //    diretoryModle.diretory = jsonReader.Value.ToString();
            //    diretoryList.Add(diretoryModle);
            //    cmb_devices.DataSource = diretoryList;
            //}




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
