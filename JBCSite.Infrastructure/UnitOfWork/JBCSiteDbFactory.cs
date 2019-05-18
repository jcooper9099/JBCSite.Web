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

        protected IDbContext context;        

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IDbContext Init()
        {
            if(context == null)
            {
                context = new JBCSiteContext();
            }            
            return context;
        }        
    }
}
