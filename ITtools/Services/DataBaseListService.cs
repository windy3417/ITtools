using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Sql;
using Utility;
using System.Data;
using System.Data.SqlClient;

namespace ITtools.Services
{
    class DataBaseListService
    {
        public DataTable dataBaseList()
        {
            string sql = "SELECT Name from SysDatabases ORDER BY Name";
            return Sqlhelper.GetDataTable(sql,Sqlhelper.dataSourceType.it);
        }

    }
}
