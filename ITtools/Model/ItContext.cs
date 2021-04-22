namespace ITtools.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.SQLite.EF6;
    using System.Linq;
    

    public class ItContext : DbContext
    {
       
        public ItContext()
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business),true)
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.it), true)
        {
        }

       

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<WebURLModel> WebURLs { get; set; }

        public virtual DbSet<DiretoryModle> Diretory { get; set; }

        public virtual DbSet<MaxKeyModel> MaxKeys { get; set; }
    }

   
}