using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.DAL;
using Utility.Model;
using static Utility.Sql.Sqlhelper;
using Utility.Files;

namespace ITtools.UI.SetUp
{
    public partial class FrmSmbConfig : Form
    {
        public FrmSmbConfig()

        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbTest_Click(object sender, EventArgs e)
        {
            
            SmbFiels smbFiels = new SmbFiels();

            try
            {
                if (smbFiels.ConnectTest(txtHostName.Text, txtUser.Text, txtPwd.Text))
                {
                    MessageBox.Show("测试连接成功！");
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message+ex.InnerException);
            }
         


            
           
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// save connecting  string of smb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbSave_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.txtHostName.Text;
            m.DataBase = this.txtFoldDirectory.Text;
            m.UserName = this.txtUser.Text;
            m.Pwd = this.txtPwd.Text;

            //存储到物理文件SmbConnectiongString.text

             
            ConnectString connectString = new ConnectString();
            connectString.PutSmbConnectionString(m,Environment.CurrentDirectory+@"/SmbConfig.bin");

         
        }

        /// <summary>
        /// 读取数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            string itFileName = Environment.CurrentDirectory + "\\" + DataSourceType.it.ToString() + "DBConfig.txt";
            string u8FileName = Environment.CurrentDirectory + "\\" + DataSourceType.u8.ToString() + "DBConfig.txt";
            Utility.DAL.ConnectString dbConnect = new ConnectString();
         
        }

    }
}
