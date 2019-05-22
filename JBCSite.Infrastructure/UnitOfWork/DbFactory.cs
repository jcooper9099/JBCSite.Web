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
        protected IDbContext context;

        public IDbContext Init(string connectionName)
        {
            return GetContext(connectionName);
        }

        /// <summary>
        /// Something of a singleton pattern here to ensure the context is initated only once
        /// </summary>
        private IDbContext GetContext(string connectionName)
        {
            if (contextCollection.ContainsKey(connectionName))
            {
                if (contextCollection[connectionName] == null || contextCollection[connectionName].IsDisposed)
                {
                    contextCollection[connectionName] = new SiteContext(connectionName);
                }
            }
            else
            {
                contextCollection.Add(connectionName, new SiteContext(connectionName));
            }

            return contextCollection[connectionName];
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
                    context.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
