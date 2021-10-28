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

namespace ITtools.UI.RefForm
{
    public partial class FrmAppPurRef : Form
    {
        public FrmAppPurRef()
        {
            InitializeComponent();
            getAppVoucherList();
        }

        void getAppVoucherList()
        {
            using (var db = new U8Context())
            {
                var q = (from s in db.PU_AppVouch.Where(s => s.cMaker == "luojing（罗璟）")
                         join p in db.PU_AppVouchs on s.ID equals p.ID
                         join n in db.Person on s.cPersonCode equals n.cPersonCode
                         join i in db.Inventory on p.cInvCode equals i.cInvCode
                         select new { s.cCode, s.dDate, s.cAuditDate, n.cPersonName, p.cInvCode, i.cInvName, i.cInvStd }).ToList();

                dataGridView1.DataSource = q;


            }
        }
    }
}
