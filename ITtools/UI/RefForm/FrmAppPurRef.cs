using ITtools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITtools.DAL.VModel;
using System.IO;

namespace ITtools.UI.RefForm
{
    public partial class FrmAppPurRef : Form
    {
        public FrmAppPurRef()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           
            getAppVoucherList();
        }

        #region delegate

        //委托、传递数据给主调用窗体
        public Action<AppPurVmodel> actionAppVoucher = null;


        #endregion


        #region get data

        void getAppVoucherList()
        {
            using (var db = new U8Context())
            {
                var q = (from s in db.PU_AppVouch.Where(s => s.cCloser == null)
                         join p in db.PU_AppVouchs on s.ID equals p.ID
                         join n in db.Person on s.cPersonCode equals n.cPersonCode
                         join i in db.Inventory.Where(s => s.cInvCCode.StartsWith("A8")) on p.cInvCode equals i.cInvCode
                         select new { s.cCode, s.dDate, s.cAuditDate, n.cPersonName, p.cInvCode, i.cInvName, i.cInvStd })
                         .OrderBy(s => s.dDate).ToList();

                dataGridView1.DataSource = q;
                dataGridView1.AutoResizeColumns();
                db.Database.Log = s =>
                {
                    FileStream fs = File.Create(Environment.CurrentDirectory + "\\test.txt");

                    fs.Write(System.Text.Encoding.Default.GetBytes(s), 0, Encoding.Default.GetByteCount(s));
                    fs.Close();
                };
              



            }
        }

        #endregion


        #region data handle

        /// <summary>
        /// return data to caller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCertain_Click(object sender, EventArgs e)
        {
            AppPurVmodel refAppPur = new AppPurVmodel();
            refAppPur.cCode = dataGridView1.CurrentRow.Cells["cCode"].Value.ToString();
            refAppPur.dDate = (DateTime)dataGridView1.CurrentRow.Cells["dDate"].Value;
            refAppPur.cPersonName = dataGridView1.CurrentRow.Cells["cPersonName"].Value.ToString();
            refAppPur.cInvCode = dataGridView1.CurrentRow.Cells["cInvCode"].Value.ToString();
            refAppPur.cInvName = dataGridView1.CurrentRow.Cells["cInvName"].Value.ToString();
            refAppPur.cInvStd = dataGridView1.CurrentRow.Cells["cInvStd"].Value is null ? "" : dataGridView1.CurrentRow.Cells["cInvStd"].Value.ToString();
            refAppPur.cAuditDate = (DateTime)dataGridView1.CurrentRow.Cells["cAuditDate"].Value;



            if (actionAppVoucher != null)
            {
                actionAppVoucher.Invoke(refAppPur);
            }
            this.Close();
        }


        #endregion

        #region 内部方法

        void writeLog(string log)
        {
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info(log);
        }

      public  void transferData(Action<AppPurVmodel> actionAppVoucher)
        {
            AppPurVmodel refAppPur = new AppPurVmodel();
            refAppPur.cCode = dataGridView1.CurrentRow.Cells["cCode"].Value.ToString();

            if (actionAppVoucher != null)
            {
                actionAppVoucher.Invoke(refAppPur);
            }
        }


        #endregion

        #region ui handle

        /// <summary>
        /// display row no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView style = new Utility.Style.StyleDataGridView();
            style.DisplayRowNo(e, dataGridView1);
            style.DataGridViewColumnHeaderStyle(dataGridView1);
        }

        #endregion

        
    }
}
