namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PrWeakCurrent", "isSettle", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PrWeakCurrent", "isSettle", c => c.Boolean(nullable: false));
        }
    }
}
