using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Infrastructure.Repository;

namespace JBCSite.Infrastructure.UnitOfWork
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private bool _disposed;
        protected Dictionary<string, IDbContext> contextCollection = new Dictionary<string, IDbContext>();
        protected IDbContext Context;

        public IDbContext Init(string connectionName)
        {
            if (Context == null)
            {
                Context = new SiteContext(connectionName);
            }
            return Context;
        }
        
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                   
                }

                _disposed = true;
            }
        }
    }
}
