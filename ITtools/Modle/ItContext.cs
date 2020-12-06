namespace ITtools.Modle
{
    using System;
    using System.Data.Entity;
    using System.Data.SQLite;
    using System.Data.SQLite.EF6;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class ItContext : DbContext
    {
       
        public ItContext()
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business),true)
            //: base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.it), true)
            //:base("Data Source = F:\\oneDrive\\Resource\\ITresource.db")
            : base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder()
                {
                    DataSource = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "F:\\oneDrive\\Resource\\ITresource.db"),
                    ForeignKeys = true
                }.ConnectionString
            }, true)
        {
            Database.Log = message => Console.WriteLine("[{0}]{1}-- {2}",
                Thread.CurrentThread.ManagedThreadId, 
                DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), message.Trim());
            //Utility.Log.Logs.LogWriteWtihString(Database.Log);
        }

       

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<WebURLModle> WebURLs { get; set; }
    }

   
}