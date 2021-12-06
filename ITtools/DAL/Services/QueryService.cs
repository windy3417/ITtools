using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Utility.Sql;

namespace ITtools.Model.DAL.Services
{
    public class QueryService<TEntity> where TEntity : class, new()
    {
        public List<TEntity> GetDataList()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name;
            string sql = "select * from " + tableName;
            PropertyInfo[] proInfo = modelType.GetProperties();


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql, Sqlhelper.DataSourceType.it);
            while (sqlDataReader.Read())
            {
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    item.SetValue(m, sqlDataReader[propertyName]);
                }

                entityList.Add(m);

            }

            return entityList;

        }
    }




}

