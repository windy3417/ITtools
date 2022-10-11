using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ITtools.DAL.VModel;
using ITtools.Model;
using ITtools.Model.IT;
using ITtools.Model.U8;

namespace ITtools.DAL.Services
{
    public class WeakCurrenceSettleService
    {
        public List<WeakCurrentSettleVmodel> getProject(Expression<Func<PU_AppVouch,bool>>filter1, Expression<Func<PrWeakCurrentModel, bool>> filter2)
        {
            using (var db = new ItContext())
            {
                List<WeakCurrentSettleVmodel> projectList = new List<WeakCurrentSettleVmodel>();

                using (var u8 = new U8Context())
                {

                    //不能同时实例化两个上下文，所以分开查询，再合并，注意ToArray()方法以实现避免联合查询
                    //u8 database
                    var q = (from s in u8.PU_AppVouch.Where(filter1.Compile())
                             join p in u8.PU_AppVouchs on s.ID equals p.ID
                             join n in u8.Person on s.cPersonCode equals n.cPersonCode
                             join i in u8.Inventory on p.cInvCode equals i.cInvCode
                             select new { s.cCode,p.AutoID, s.dDate, s.cAuditDate, n.cPersonName, i.cInvCode, i.cInvName, i.cInvStd, p.cbcloser})
                             .ToArray();
                    
                    //business database
                    var q1 = from s in q
                             join w in db.PrWeakCurrent.Where(filter2.Compile())
                             on  s.cCode equals w.PrVoucherNo
                             where s.AutoID == w.RowID
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
                                 s.cbcloser,
                                 w.SendEmailAmount
                                 
                             };
                            
                             


                    foreach (var item in q1)
                    {
                        WeakCurrentSettleVmodel m = new WeakCurrentSettleVmodel();
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
                        m.SendEmailAmount = item.SendEmailAmount is null ? 0 : item.SendEmailAmount;
                        projectList.Add(m);
                    }


                   
                }

                return projectList;

            }


        }
    }
}
