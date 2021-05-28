namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrWeakCurrent",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PrVoucherNo = c.String(),
                        projectContent = c.String(),
                        PrDate = c.DateTime(nullable: false),
                        PrPerson = c.String(),
                        isSettle = c.Boolean(nullable: false),
                        settleDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PrWeakCurrent");
        }
    }
}
