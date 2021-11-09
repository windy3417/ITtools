using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITtools.DAL.VModel;
using ITtools.Model;

namespace ITtools.DAL.Services
{
    public class ProjectSettleService
    {
        public List<ProjectSettleVmodel> getProject()
        {
            using (var db = new ItContext())
            {
                List<ProjectSettleVmodel> projectList = new List<ProjectSettleVmodel>();

                using (var u8 = new U8Context())
                {

                    //不能同时实例化两个上下文，所以分开查询，再合并，注意ToArray()方法以实现避免联合查询
                    var q = (from s in u8.PU_AppVouch.Where(s => s.cMaker == "luojing（罗璟）")
                             join p in u8.PU_AppVouchs on s.ID equals p.ID
                             join n in u8.Person on s.cPersonCode equals n.cPersonCode
                             join i in u8.Inventory on p.cInvCode equals i.cInvCode
                             select new { s.cCode, s.dDate, s.cAuditDate, n.cPersonName, i.cInvCode, i.cInvName, i.cInvStd, p.cbcloser})
                             .ToArray();

                    var q1 = from s in q
                             join w in db.PrWeakCurrent on s.cCode equals w.PrVoucherNo
                             orderby s.dDate
                             select new
                             {
                                 s.cCode,
                                 s.dDate,
                                 s.cAuditDate,
                                 s.cPersonName,
                                 s.cInvCode,
                                 s.cInvName,
                                 s.cInvStd,
                                 w.isSettle,
                                 w.settleDate,
                                 s.cbcloser
                                 
                             };
                            
                             


                    foreach (var item in q1)
                    {
                        ProjectSettleVmodel m = new ProjectSettleVmodel();
                        m.cCode = item.cCode;
                        m.dDate = item.dDate.ToString();
                        m.cAuditDate = item.cAuditDate.ToString();
                        m.cPersonName = item.cPersonName;
                        m.cInvCode = item.cInvCode;
                        m.cInvName = item.cInvName;
                        m.cInvStd = item.cInvStd;
                        m.settleFlag = item.isSettle;
                        m.settleDate = item.settleDate;
                        m.IsClose = item.cbcloser is null ? "" : item.cbcloser;
                        projectList.Add(m);
                    }


                   
                }

                return projectList;

            }


        }
    }
}
