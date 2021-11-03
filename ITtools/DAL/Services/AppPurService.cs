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
  public  class AppPurService

    {
        /// <summary>
        /// 获取请购单
        /// </summary>
        /// <returns></returns>
        public List<AppPurVmodel> getAppPur(string closeStutas)
        {
            using (var db =new U8Context())
            {
                List<AppPurVmodel> appPurList = new List<AppPurVmodel>();

                var q = from s in db.PU_AppVouch.Where(s => s.cMaker == "luojing（罗璟）" & s.cCloser == closeStutas)
                         join p in db.PU_AppVouchs on s.ID equals p.ID
                         join n in db.Person on s.cPersonCode equals n.cPersonCode
                         join i in db.Inventory on p.cInvCode equals i.cInvCode
                         select new { s.cCode, s.dDate, s.cAuditDate, n.cPersonName, p.cInvCode, i.cInvName, i.cInvStd };

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
                    AppPurVmodel m = new AppPurVmodel();
                    m.cCode = item.cCode;
                    m.dDate = item.dDate.ToString();
                    m.cAuditDate = item.cAuditDate.ToString();
                    m.cPersonName = item.cPersonName;
                    m.cInvCode = item.cInvCode;
                    m.cInvName = item.cInvName;
                    m.cInvStd = item.cInvStd;
                    appPurList.Add(m);
                }

             

                return appPurList;
            }
        }
    }
}
