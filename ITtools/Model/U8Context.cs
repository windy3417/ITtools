namespace ITtools.Model
{
    using ITtools.Model.U8;
    using System;
    using System.Data.Entity;
    using System.Data.SQLite.EF6;
    using System.Linq;
    

    public class U8Context : DbContext
    {
       
        public U8Context()
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business),true)
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.u8), true)
        {
        }

        
        public virtual DbSet<U8CUSTDEF_0044_E002> U8CUSTDEF_0044_E002 { get; set; }
        public virtual DbSet<U8CUSTDEF_0061_E001> U8CUSTDEF_0061_E001 { get; set; }
        public virtual DbSet<U8CUSTDEF_0061_E002> U8CUSTDEF_0061_E002 { get; set; }
        //外发需返主表
        public virtual DbSet<U8CUSTDEF_0058_E001> U8CUSTDEF_0058_E001 { get; set; }
        //外发需返子表
        public virtual DbSet<U8CUSTDEF_0058_E001> U8CUSTDEF_0058_E002 { get; set; }

    }

   
}