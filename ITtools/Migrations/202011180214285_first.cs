namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebURLModles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        introduction = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebURLModles");
        }
    }
}
