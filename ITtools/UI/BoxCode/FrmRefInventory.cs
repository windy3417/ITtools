using ITtools.Model.U8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.UI.BoxCode
{
    public partial class FrmRefInventory : Form
    {

        public FrmRefInventory()
        {
            InitializeComponent();
            GetInventory();
        }

       public Action<string> ActionGetInventory;

        #region get data
        void GetInventory()
        {
            var list = (from s in Utility.DAL.QueryService.GetSingleTable<Xm_BoxCode>(Utility.Sql.Sqlhelper.DataSourceType.u8)
                        select new { s.InvCode, s.InvName, s.InvStd }).Distinct();
            dgv.DataSource = list.ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Xm_BoxCode m = new Xm_BoxCode();
           
            var list = (from s in Utility.DAL.QueryService.GetSingleTable<Xm_BoxCode>(Utility.Sql.Sqlhelper.DataSourceType.u8)
                        where  s.InvCode.Contains(txtSerchString.Text) || s.InvName.Contains(txtSerchString.Text) || s.InvStd.Contains(txtSerchString.Text)
                        select new { s.InvCode, s.InvName, s.InvStd }).Distinct();
            dgv.DataSource = list.ToList();
        }

        #endregion



        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.DataGridViewStyle s = new Utility.Style.DataGridViewStyle();
            s.DataGridViewColumnHeaderStyle(dgv);
            s.DisplayRowNo(e,dgv, false);
        }

        private void tsbCertain_Click(object sender, EventArgs e)
        {
            string invCode = dgv.CurrentRow.Cells["invCode"].Value.ToString();
            ActionGetInventory?.Invoke(invCode);
            this.Close();
        }

      
    }
}
