using JBCSite.Auth.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace JBCSite.Auth
{
    public partial class AuthContext : IdentityDbContext
    {
        public AuthContext() : base("name=AuthContext")
        {

        }        
    }
}
