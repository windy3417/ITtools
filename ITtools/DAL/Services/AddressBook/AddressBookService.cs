using ITtools.Model.IT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Sql;

namespace ITtools.DAL.Services.AddressBook
{
  public  class AddressBookService
    {
        public List<Model.IT.addressBook> GetAddresBook(SqlParameter[] sqlParameters)
        {
            List<Model.IT.addressBook> addressBookList = new List<Model.IT.addressBook>();

            StringBuilder sql = new StringBuilder();
              sql.Append(  "select * from addressBook where  1=1 ");
            if (sqlParameters.Count()>0)
            {
                foreach (var item in sqlParameters)
                {

                    sql.Append($" and {item.ParameterName.Replace("@","")}= {item.ParameterName}");

                }
                                               
            }

         SqlDataReader sqlDataReader=   Sqlhelper.GetSqlDataReader(sql.ToString(), sqlParameters, Sqlhelper.DataSourceType.it);
           

            while (sqlDataReader.Read())
            {
                Model.IT.addressBook m = new Model.IT.addressBook();
                m.chinessName = sqlDataReader["chinessName"].ToString();
                m.department= sqlDataReader["department"].ToString();
                m.Ext =Convert.ToDouble( sqlDataReader["Ext"]);

                addressBookList.Add(m);
             
            }

            return addressBookList;
          
         
        }

        public DataTable GetAddresBookAsDataTable(SqlParameter[] sqlParameters )
        {
            
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from addressBook where  1=1 ");

            if (sqlParameters==null)
            {
             
                return Sqlhelper.GetDataTable(sql.ToString(),Sqlhelper.DataSourceType.it);
            }

            else
            {
                foreach (var item in sqlParameters)
                {

                    sql.Append($" and {item.ParameterName.Replace("@","")}= {item.ParameterName}");

                }
                return Sqlhelper.GetDataTable(sql.ToString(), sqlParameters, Sqlhelper.DataSourceType.it);
            }

        

                    
          
           
        }


    }
}
