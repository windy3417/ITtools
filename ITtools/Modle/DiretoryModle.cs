using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace ITtools.Modle
{
    [Serializable]
  public  class DiretoryModle
    {
        [Key]
        public string directoryID { get; set; }
        public string diretory { get; set; }
    }
}
