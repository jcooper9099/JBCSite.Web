using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using JBCSite.Auth.Models;

namespace JBCSite.Auth
{
    public partial class AuthContext : IdentityDbContext
    {
        public AuthContext() : base("name=AuthContext")
        {

        }

        public DbSet<Permission> Permissions { get; set; }

        DbSet<RolePermission> RolePermissions { get; set; }
    }
}
