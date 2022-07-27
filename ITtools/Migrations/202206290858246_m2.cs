namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrWeakCurrent", "UpLoadFlag", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PrWeakCurrent", "UpLoadFlag");
        }
    }
}
