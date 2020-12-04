namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebURLModles", "ResourceClass", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebURLModles", "ResourceClass");
        }
    }
}
