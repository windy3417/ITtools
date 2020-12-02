namespace ITtools.Modle
{
    using System;
    using System.Data.Entity;
    using System.Data.SQLite.EF6;
    using System.Linq;
    

    public class ItContext : DbContext
    {
       
        public ItContext()
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business),true)
            : base("Data Source=E:\\OneDrive\\Resource\\itResource.db")
        {
        }

       

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<WebURLModle> WebURLs { get; set; }
    }

   
}