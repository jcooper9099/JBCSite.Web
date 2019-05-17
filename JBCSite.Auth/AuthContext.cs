using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Auth.Models;
using System.Data.Entity;

namespace JBCSite.Auth
{
    public class AuthContext : IdentityDbContext<AppUser>
    {
        public AuthContext() : base("name=AuthContext")
        {
        }

        

    }
}
