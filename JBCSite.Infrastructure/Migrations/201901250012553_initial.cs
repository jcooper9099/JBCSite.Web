namespace JBCSite.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemoInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DemoId = c.Int(nullable: false),
                        DemoTitle = c.String(),
                        DemoDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DemoObjects", t => t.DemoId, cascadeDelete: true)
                .Index(t => t.DemoId);
            
            CreateTable(
                "dbo.DemoObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DemoText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DemoInfoes", "DemoId", "dbo.DemoObjects");
            DropIndex("dbo.DemoInfoes", new[] { "DemoId" });
            DropTable("dbo.DemoObjects");
            DropTable("dbo.DemoInfoes");
        }
    }
}
