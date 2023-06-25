using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ITtools.Model.Scrap
{
    public partial class ScrapContext : DbContext
    {
        public ScrapContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.business), true)
        {
        }

        public virtual DbSet<WeighingSettlement> WeighingSettlement { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
