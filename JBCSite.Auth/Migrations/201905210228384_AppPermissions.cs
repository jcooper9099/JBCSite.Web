namespace JBCSite.Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppPermissions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppPermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppPermissions");
        }
    }
}
