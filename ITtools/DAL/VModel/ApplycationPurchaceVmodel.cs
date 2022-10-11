using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.DAL.VModel
{
    public class ApplycationPurchaceVmodel
    {
        public string cCode { get; set; }
        public int RowID { get; set; }
        public DateTime dDate { get; set; }
        public DateTime cAuditDate { get; set; }
        public string cPersonName { get; set; }

        public string cInvCode { get; set; }
        public string cInvName { get; set; }
        public string cInvStd { get; set; }

    }
}
