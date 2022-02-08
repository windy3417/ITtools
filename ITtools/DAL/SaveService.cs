using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITtools.DAL
{
  public  class SaveService
    {



        /// <summary>
        /// 单表保存
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void SaveSingleDate<TEntity,Context>(TEntity entity) where TEntity : class  where Context : DbContext,new ()
        {

            try
            {
                using (var db = new Context())
                {


                    db.Set<TEntity>().Add(entity);

                    db.SaveChanges();

                    MessageBox.Show("数据保存成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

    }
}
