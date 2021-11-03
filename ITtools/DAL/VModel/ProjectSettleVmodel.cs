using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.DAL.VModel
{
  public  class ProjectSettleVmodel
    {

        public string cCode { get; set; }
        public string dDate { get; set; }
        public string cAuditDate { get; set; }
        public string cPersonName { get; set; }

        public string cInvCode { get; set; }
        public string cInvName { get; set; }
        public string cInvStd { get; set; }
        public Nullable< bool> settleFlag { get; set; }
        public Nullable< DateTime> settleDate { get; set; }
    }
}
