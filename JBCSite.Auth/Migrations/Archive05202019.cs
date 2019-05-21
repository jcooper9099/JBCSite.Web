using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Auth.Models;

namespace JBCSite.Auth.Migrations
{
    public partial class Archive
    {
        public static void SetInitialPermissions(AuthContext context)
        {
            var newPermissions = new List<string> {
                "CreateBlog",
                "EditBlog",
                "Comment"
            };

            foreach (var perm in newPermissions)
            {
                context.Permissions.AddOrUpdate(x => x.Name, new Permission { Id = Guid.NewGuid(), Name = perm });
            }

            context.SaveChanges();
        }
    }
}
