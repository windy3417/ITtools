using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITtools.Modle
{
   public class WebURLModle
    {
        public int id { get; set; }
        public string introduction { get; set; }
        
        public string url { get; set; }
        public int ResourceClass{ get;set;}
    }
}
