using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITtools.Model;

namespace ITtools.Services
{
  public  class AppPurVouchService
    {
        //public DataTable getAppPurVoucher(string voucherNo)
        //{
        //    DataTable dt = new DataTable();
        //    using (var db = new U8Context())
        //    {
        //        var q = (from s in db.PU_AppVouch.Where(s => s.cCode == voucherNo)
        //                 join p in db.PU_AppVouchs on s.ID equals p.ID
        //                 join n in db.Person on s.cPersonCode equals n.cPersonCode
        //                 join i in db.Inventory on p.cInvCode equals i.cInvCode
        //                 select new { s.cCode, s.dDate, s.cAuditDate, n.cPersonName, p.cInvCode, i.cInvName, i.cInvStd }).ToList();


        //    }
        //}
    }
}
