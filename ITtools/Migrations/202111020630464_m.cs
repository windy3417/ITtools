namespace ITtools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
           
            
            CreateTable(
                "dbo.PrWeakCurrent",
                c => new
                    {
                        PrVoucherNo = c.String(nullable: false, maxLength: 128),
                        projectContent = c.String(),
                        PrDate = c.DateTime(nullable: false),
                        PrPerson = c.String(),
                        isSettle = c.Boolean(nullable: false),
                        settleDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PrVoucherNo);
            
         
            
        }
        
        public override void Down()
        {
       
            DropTable("dbo.PrWeakCurrent");
         
        }
    }
}
