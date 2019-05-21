namespace JBCSite.Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role_RolePermissions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePermissions", "PermissionId", "dbo.Permissions");
            DropIndex("dbo.RolePermissions", new[] { "PermissionId" });
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Permissions");
        }
    }
}
