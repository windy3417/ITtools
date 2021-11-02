using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.Model
{
   public static class EnumModle
    {
    public   enum ITenum
        {
            Sharp通用=0,
            EF=1,
            微信小程序=2,
            sql=7,
            云存储=8,
            开源类库=9,
            教程=11,
            Office=21,
            用友=31,
            企业管理=41,
            
        }
        public enum saveOrChangeOrQueryMolde
        {
            save,
            change,
            query
        }

    }
}
