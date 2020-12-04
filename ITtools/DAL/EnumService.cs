using ITtools.Modle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITtools.DAL
{
  public  class EnumService
    {

        public Dictionary<int,String> GetITenum()
        {
            Dictionary<int, String> keyValuePairs = new Dictionary<int, string>();
        
            foreach (string value in Enum.GetNames(typeof(EnumModle.ITenum)))
            {
                int key = (int)Enum.Parse(typeof(EnumModle.ITenum), value);
                keyValuePairs.Add(key, value); //添加keyvalue键值对
              
              
            }
            return keyValuePairs;
        }
    }
}
