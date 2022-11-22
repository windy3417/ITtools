namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.department", "EnglishName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.department", "EnglishName");
        }
    }
}
