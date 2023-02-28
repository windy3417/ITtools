using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITtools.Model;
using ITtools.Model.IT;

namespace ITtools.Services
{
   public class WebURLService
    {
        public List<WebUrl> GetWebURLs()
        {
            using (var db =new ItContext())
            {
                return db.WebUrl.ToList();
            }
        }
    }
}
