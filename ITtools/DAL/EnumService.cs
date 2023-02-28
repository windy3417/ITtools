using ITtools.Model;
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
        
            foreach (string value in System.Enum.GetNames(typeof(Model.Enum.ITenum)))
            {
                int key = (int)System.Enum.Parse(typeof(Model.Enum.ITenum), value);
                keyValuePairs.Add(key, value); //添加keyvalue键值对
              
              
            }
            return keyValuePairs;
        }
    }
}
