using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Infrastructure.Repository;

namespace JBCSite.Infrastructure.UnitOfWork
{
    public class JBCSiteDbFactory : IDbFactory, IDisposable
    {
        private bool _disposed;
        protected Dictionary<string, IDbContext> contextCollection = new Dictionary<string, IDbContext>();
        protected IDbContext context;        

        public void Dispose()
        {
            throw new NotImplementedException();
        }

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
                if (contextCollection[connectionName] == null)
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
    }
}
