using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JBCSite.Auth
{
    public interface IAuthContext
    {
        DbSet<IdentityUser> AppUsers { get; set; }
        DbSet<IdentityRole> Roles { get; set; }
    }
}