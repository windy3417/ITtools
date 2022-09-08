using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITtools.Model.IT
{
    [Table("PrWeakCurrent")]
  public  class PrWeakCurrentModel
    {
        [Key]
        public string PrVoucherNo { get; set; }
        public string projectContent { get; set; }
        public DateTime PrDate { get; set; }
        public string PrPerson { get; set; }
        public Nullable<bool> isSettle { get; set; }
        public Nullable<DateTime> settleDate { get; set; }
        public Nullable<bool> UpLoadFlag { get; set; }

        public Nullable<int> SendEmailAmount { get; set; }

    }
}
