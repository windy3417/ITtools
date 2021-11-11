using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ITtools.Model.Scrap
{
    public partial class ScrapContext : DbContext
    {
        public ScrapContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<WeighingSettlementModels> WeighingSettlementModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
