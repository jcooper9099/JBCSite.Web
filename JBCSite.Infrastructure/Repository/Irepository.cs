using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JBCSite.Infrastructure.Repository
{
    /// <summary>
    /// Defines the responsibilties of an respository
    /// <para>Note that many of the functions mimic Linq ;)</para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(object id);

        T FindById(object id);

        Task<T> FindByIdAsync(object id);

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();

        Task<List<T>> GetAllAsync();

        List<T> PageAll(int skip, int take);
    }
}
