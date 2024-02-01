using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ITtools.Model.IT
{
    public partial class ItContext : DbContext
    {
        public ItContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection(Utility.Sql.Sqlhelper.DataSourceType.it), true)
        {
        }

        public virtual DbSet<addressBook> addressBook { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Directory> Directory { get; set; }
        public virtual DbSet<MaxKeys> MaxKeys { get; set; }
        public virtual DbSet<PrWeakCurrent> PrWeakCurrent { get; set; }
        public virtual DbSet<WebUrl> WebUrl { get; set; }
        public virtual DbSet<AttachFiles> AttachFiles { get; set; }
        public virtual DbSet<V_Addressbook> V_Addressbook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<addressBook>()
                .Property(e => e.deptID)
                .IsUnicode(false);

            modelBuilder.Entity<addressBook>()
                .Property(e => e.memoryCode)
                .IsFixedLength();

            modelBuilder.Entity<V_Addressbook>()
                .Property(e => e.deptID)
                .IsFixedLength();
        }
    }
}
