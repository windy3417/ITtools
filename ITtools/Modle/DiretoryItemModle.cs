using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.Modle
{
    class DiretoryItemModle:IEquatable<DiretoryItemModle>
    {
        public string path;
        public DiretoryItemModle(string path)
        {
            this.path = path;
        }

        public bool Equals(DiretoryItemModle other)
        {
            if (other==null)
            {
                return false;
            }
            return (this.path.Equals(other.path));
        }
    }
}
