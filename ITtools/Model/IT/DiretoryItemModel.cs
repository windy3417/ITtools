using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.Model
{
    class DiretoryItemModel:IEquatable<DiretoryItemModel>
    {
        public string path;
        public DiretoryItemModel(string path)
        {
            this.path = path;
        }

        public bool Equals(DiretoryItemModel other)
        {
            if (other==null)
            {
                return false;
            }
            return (this.path.Equals(other.path));
        }
    }
}
