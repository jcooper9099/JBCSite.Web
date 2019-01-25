using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace JBCSite.Infrastructure.Repository
{
    /// <summary>
    /// Acts as a class to implement IRepository in some way
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericDbRespository<T> : IRepository<T> where T : class
    {
        private IDbContext _context; // will be instantiated by UnitOfWork instance

        private readonly IDbSet<T> _dbset;

        public void Insert(T entity)
        {
            _dbset.Add(entity);
        }

        public GenericDbRespository(IDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public void Update(T entity)
        {
            var entry = _context.Entry(entity);
            _dbset.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
            _dbset.Remove(entity);
        }

        public T Get(object id)
        {
            return _dbset.Find(id);
        }

        public T FindById(object id)
        {
            return _dbset.Find(id);
        }

        public Task<T> FindByIdAsync(object id)
        {
            return ((DbSet<T>)_dbset).FindAsync(id);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbset.FirstOrDefault(predicate);
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbset.FirstOrDefaultAsync(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbset.SingleOrDefault(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset;
        }

        public Task<List<T>> GetAllAsync()
        {
            return _dbset.ToListAsync();
        }

        public List<T> PageAll(int skip, int take)
        {
            return _dbset.Skip(skip).Take(take).ToList();
        }
    }
}
