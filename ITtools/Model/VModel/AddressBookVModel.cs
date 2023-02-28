using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITtools.DAL.VModel
{
  public  class AddressBookVModel
    {
   
        public int AddresssBookID { get; set; }
        public string DepartmentName { get; set; }

       
        public string EnglishPersonName { get; set; }

  
        public string ChinessPersonName { get; set; }

        public double? Ext { get; set; }

        public double? MobilePhoneNumber { get; set; }


        public string MobilePhoneShortNumber { get; set; }

 
        public string EmailAddress { get; set; }

     
    }
}
