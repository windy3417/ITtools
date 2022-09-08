namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PrWeakCurrent", "SendEmailAmount", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PrWeakCurrent", "SendEmailAmount", c => c.Int(nullable: false));
        }
    }
}
