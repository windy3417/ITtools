namespace ITtools.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.SQLite.EF6;
    using System.Linq;
    using ITtools.Model.IT;


    public class ItContext : DbContext
    {

        public ItContext()
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business),true)
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.it), true)
        {
        }



        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<WebURLModel> WebURLs { get; set; }

        public virtual DbSet<DiretoryModel> Diretory { get; set; }

        public virtual DbSet<MaxKeyModel> MaxKeys { get; set; }
        public virtual DbSet<PrWeakCurrentModel>  PrWeakCurrent {get;set;  }

        public virtual DbSet<AddressBookModel> AddressBook { get; set; }
        public virtual DbSet<department> Department { get; set; }
    }

   
}