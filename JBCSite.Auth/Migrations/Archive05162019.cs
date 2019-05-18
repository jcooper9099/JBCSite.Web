using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JBCSite.Auth.Migrations
{
    public partial class Archive
    {
        public static void SetInitialRoles(AuthContext context)
        {
            context.Roles.AddOrUpdate(x => new { x.Id, x.Name }, new IdentityRole("Admin"));
            context.Roles.AddOrUpdate(x => new { x.Id, x.Name }, new IdentityRole("Blogger"));
            context.Roles.AddOrUpdate(x => new { x.Id, x.Name }, new IdentityRole("User"));
            context.Roles.AddOrUpdate(x => new { x.Id, x.Name }, new IdentityRole("Lurker"));

            context.SaveChanges();
        }
    }
}
