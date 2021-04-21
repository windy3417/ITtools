namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaxKeyModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        VoucherCode = c.Int(nullable: false),
                        VoucherName = c.String(),
                        CurrentKeyValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaxKeyModels");
        }
    }
}
