namespace JBCSite.Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolePermissions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppPermissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePermissions", "PermissionId", "dbo.AppPermissions");
            DropIndex("dbo.RolePermissions", new[] { "PermissionId" });
            DropTable("dbo.RolePermissions");
        }
    }
}
