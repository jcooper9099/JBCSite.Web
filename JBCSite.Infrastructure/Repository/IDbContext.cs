using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBCSite.Infrastructure.Repository
{
    public interface IDbContext: IDisposable
    {
        bool IsDisposed { get; set; }

        DbSet<T> Set<T>() where T: class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        SqlProviderServices GetSqlProviderInstance();
    }
}
