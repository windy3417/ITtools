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
  public  class DepartmentService
    {
        public DataTable GetDepartment()
        {

            string sql = "select * from department ";


            return Sqlhelper.GetDataTable(sql.ToString(), Sqlhelper.DataSourceType.it);

        }

        public List<department> GetDepanrtmentList()
        {
            List<department> departmentList = new List<department>();

            string sql = "select * from department";
        

            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), Sqlhelper.DataSourceType.it);


            while (sqlDataReader.Read())
            {
                department m = new department();
                m.deptID = sqlDataReader["deptID"].ToString();
                m.deptName = sqlDataReader["deptName"].ToString();
             

                departmentList.Add(m);

            }

            return departmentList;
        }
    }
}
