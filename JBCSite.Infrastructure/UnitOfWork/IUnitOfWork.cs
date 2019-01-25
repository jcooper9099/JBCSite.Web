using JBCSite.Infrastructure.Repository;
using System;
using System.Threading.Tasks;

namespace JBCSite.Infrastructure.UnitOfWork
{
    /// <summary>
    /// Defines the basic responsibilities of a Unit of Work
    /// </summary>
    public interface IUnitOfWork<TDbFactory> : IDisposable
    {
        /// <summary>
        /// An instance of IdbFactory
        /// </summary>
        IDbFactory DbFactory { get; }

        /// <summary>
        /// Gets a repository of the type specified
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IRepository<T> GetRepository<T>() where T : class;

        /// <summary>
        /// Rolls back a transation
        /// </summary>
        void RollBack();

        /// <summary>
        /// Commits a transaction
        /// </summary>
        int Commit();

        /// <summary>
        /// Commits a transaction asynchronusly
        /// </summary>
        /// <returns></returns>
        Task<int> CommitAsync();
    }
}
