using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITtools.Model
{
    public class MaxKeyModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int VoucherCode { get; set; }
        public string VoucherName { get; set; }
        public int CurrentKeyValue { get; set; }

    }
}
