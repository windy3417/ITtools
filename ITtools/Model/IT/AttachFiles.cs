using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.Model.IT
{
   public class AttachFiles

    {
        public int Id { get; set; }
        public string VoucherID { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; } // This will hold the binary file content
    }
}
