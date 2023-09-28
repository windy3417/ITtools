using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Sql;

namespace ITtools.Test
{
    class UpdateService
    {
        public static void Update<TEntity>(TEntity entity, string filed, object value, string filterFild, SqlParameter[] sqlparameters) where TEntity : class
             , new()
        {

            try
            {


                string tableName = entity.GetType().Name;
                string sql = $"update {tableName} set { filed} ={value} where {filterFild}=@{filterFild} ";
                Sqlhelper.UpdateWithparameters(sql, Sqlhelper.DataSourceType.business, sqlparameters);

                //data after change



                MessageBox.Show("数据修改成功");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }
    }
}
