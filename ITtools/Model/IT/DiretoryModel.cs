using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ITtools.Model
{
    [Serializable]
    [Table("Directory")]
  public  class DiretoryModel
    {
        [Key]
        public string directoryID { get; set; }

        public string directoryType { get; set; }

        public string diretory { get; set; }
    }
}
