using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;

namespace JBCSite.Auth.Migrations
{
    public partial class Archive
    {
        public static void SetInitialRoles(AuthContext context)
        {            
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Admin"));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Blogger"));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("User"));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Lurker"));

            context.SaveChanges();
        }
    }
}
