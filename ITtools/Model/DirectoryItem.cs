using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.Model
{
    class DiretoryItem : IEquatable<DiretoryItem>
    {
        public string path;
        public DiretoryItem(string path)
        {
            this.path = path;
        }

        public bool Equals(DiretoryItem other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.path.Equals(other.path));
        }
    }
}