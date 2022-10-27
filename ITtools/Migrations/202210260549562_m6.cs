namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m6 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PrWeakCurrent");
            AddPrimaryKey("dbo.PrWeakCurrent", new[] { "PrVoucherNo", "RowID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PrWeakCurrent");
            AddPrimaryKey("dbo.PrWeakCurrent", "PrVoucherNo");
        }
    }
}
