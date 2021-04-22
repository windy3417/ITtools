namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directory",
                c => new
                    {
                        directoryID = c.String(nullable: false, maxLength: 128),
                        diretory = c.String(),
                    })
                .PrimaryKey(t => t.directoryID);
            
            CreateTable(
                "dbo.MaxKeys",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        VoucherCode = c.Int(nullable: false),
                        VoucherName = c.String(),
                        CurrentKeyValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.WebUrl",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        introduction = c.String(),
                        url = c.String(),
                        ResourceClass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebUrl");
            DropTable("dbo.MaxKeys");
            DropTable("dbo.Directory");
        }
    }
}
