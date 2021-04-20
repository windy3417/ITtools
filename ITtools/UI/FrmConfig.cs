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

namespace ITtools.UI
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            this.FormClosed += CloseParentForm;
        }

        #region 变量
        #endregion


        private void CloseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TsbTest_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();
         
            m.DataSource = this.dbConnectControl1.TxtServer.Text;
            m.DataBase = this.dbConnectControl1.TxtDataBase.Text;
            m.UserName = this.dbConnectControl1.TxtUser.Text;
            m.Pwd = this.dbConnectControl1.TxtPWD.Text;

            Utility.DAL.DbConnect dbConnect = new Utility.DAL.DbConnect();
            dbConnect.DbConnectTest(m);
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            ConnectStringModel m = new ConnectStringModel();

            m.DataSource = this.dbConnectControl1.TxtServer.Text;
            m.DataBase = this.dbConnectControl1.TxtDataBase.Text;
            m.UserName = this.dbConnectControl1.TxtUser.Text;
            m.Pwd = this.dbConnectControl1.TxtPWD.Text;

            //存储到AppConfig文件中
            DbConnect dbConnect = new DbConnect();
            dbConnect.DbConnectStringSave(m, DataSourceType.it.ToString());

            //存储为Json文件
            m.Pwd = Utility.Encrypt.Encode("mixture"); //不存储真实密码
            string fileName= Environment.CurrentDirectory + "\\" + DataSourceType.it.ToString() + "DBConfig.txt";
            Utility.Files.JsonOperate jsonOperate = new Utility.Files.JsonOperate();
            jsonOperate.ModelToJsonFile(fileName, m);
        }

        /// <summary>
        /// 读取数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            string fileName = Environment.CurrentDirectory + "\\" + DataSourceType.it.ToString() + "DBConfig.txt";
            Utility.DAL.DbConnect dbConnect = new DbConnect();
            dbConnect.ReadConfig(fileName, this.lblStatus);
        }
    }
}
