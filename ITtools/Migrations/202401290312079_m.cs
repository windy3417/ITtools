namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.AttachFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
         
        }
        
        public override void Down()
        {
        
            DropTable("dbo.AttachFiles");
        
        }
    }
}
