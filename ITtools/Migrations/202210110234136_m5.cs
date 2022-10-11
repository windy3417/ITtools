namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrWeakCurrent", "RowID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PrWeakCurrent", "RowID");
        }
    }
}
