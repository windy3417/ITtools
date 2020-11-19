using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITtools.Modle;

namespace ITtools.Services
{
   public class WebURLService
    {
        public List<WebURLModle> GetWebURLs()
        {
            using (var db =new ItContext())
            {
                return db.WebURLs.ToList();
            }
        }
    }
}
