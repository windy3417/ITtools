namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiretoryModles",
                c => new
                    {
                        directoryID = c.String(nullable: false, maxLength: 128),
                        diretory = c.String(),
                    })
                .PrimaryKey(t => t.directoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DiretoryModles");
        }
    }
}
