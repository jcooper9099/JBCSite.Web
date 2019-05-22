using JBCSite.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace JBCSite.Infrastructure.UnitOfWork
{
    public class UnitOfWork<TDbFactory> : IDisposable, IUnitOfWork<TDbFactory> where TDbFactory : IDbFactory, new()
    {
        private bool _disposed;
        private IDbContext _context;
        private string _contextName;

        public IDbFactory DbFactory { get; } = new TDbFactory();
        /// <summary>
        /// Something of a singleton pattern here to ensure the context is initated only once
        /// </summary>
        public IDbContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = DbFactory.Init(_contextName);
                }

                return _context;
            }
        }

        public UnitOfWork(string contextName)
        {
            _contextName = contextName;
        }

        private Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await Context.SaveChangesAsync();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;
            }

            var repo = new GenericDbRespository<TEntity>(Context);

            _repositories.Add(typeof(TEntity), repo);

            return repo;
        }

        public void RollBack()
        {
            foreach (DbEntityEntry entry in ((DbContext)Context).ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }
    }    
}
