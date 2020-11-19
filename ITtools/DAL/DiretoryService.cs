using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.IO;
using ITtools.UI;

namespace ITtools.DAL
{
    class DiretoryService

    {
        public JsonReader getDiretory()
        {
            String path = Environment.CurrentDirectory + "\\";
            FileStream fileStream = File.OpenRead(path + "DAL\\DirectoryItem.json");
            String jsonString = File.ReadAllText(path + "DAL\\DirectoryItem.json");
            //String jsonString = fileStream.ToString();
            return new JsonTextReader(new StreamReader(fileStream));




        }

        public String getDiretoryItem()
        {
            String path = Environment.CurrentDirectory + "\\";
            FileStream fileStream = File.OpenRead(path + "DAL\\DirectoryItem.json");
           return  File.ReadAllText(path + "DAL\\DirectoryItem.json");
          
        }
    }
}
