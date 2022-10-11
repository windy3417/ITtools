using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITtools.DAL.VModel;
using ITtools.Model;

namespace ITtools.DAL.Services
{
  public  class ApplicationPurchaseService

    {
        /// <summary>
        /// 获取请购单
        /// </summary>
        /// <returns></returns>
        public List<ApplycationPurchaceVmodel> getAppPur(string closeStutas)
        {
            using (var db =new U8Context())
            {
                List<ApplycationPurchaceVmodel> appPurList = new List<ApplycationPurchaceVmodel>();

                var q = from s in db.PU_AppVouch.Where(s => s.cMaker == "luojing（罗璟）" & s.cCloser == closeStutas)
                         join p in db.PU_AppVouchs on s.ID equals p.ID
                         join n in db.Person on s.cPersonCode equals n.cPersonCode
                         join i in db.Inventory on p.cInvCode equals i.cInvCode
                         select new { s.cCode, p.AutoID, s.dDate, s.cAuditDate, n.cPersonName, p.cInvCode, i.cInvName, i.cInvStd };

                db.Database.Log = (s) =>
                {

                    string path = Environment.CurrentDirectory + "\\MyTest.txt";
                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.Write(s);

                        }
                    }
                    else
                    {
                        using (StreamWriter sw =File.AppendText(path))
                        {
                            sw.Write(s);
                        }
                    }



                };

                foreach (var item in q)
                {
                    ApplycationPurchaceVmodel m = new ApplycationPurchaceVmodel();
                    m.cCode = item.cCode;
                    m.dDate = item.dDate;
                    m.cAuditDate = (DateTime)item.cAuditDate;
                    m.cPersonName = item.cPersonName;
                    m.cInvCode = item.cInvCode;
                    m.cInvName = item.cInvName;
                    m.cInvStd = item.cInvStd;
                    m.RowID = item.AutoID;
                    appPurList.Add(m);
                }

             

                return appPurList;
            }
        }
    }
}
