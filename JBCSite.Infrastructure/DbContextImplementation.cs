using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Infrastructure.Repository;
using System.Data.Entity.SqlServer;

namespace JBCSite.Infrastructure
{
    public partial class SiteContext : IDbContext
    {
        public SqlProviderServices SqlProviderInstance { get { return SqlProviderServices.Instance; } }
    }
}
