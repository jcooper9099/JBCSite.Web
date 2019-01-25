using JBCSite.Infrastructure.Repository;

namespace JBCSite.Infrastructure.UnitOfWork
{
    /// <summary>
    /// An interface to define the one responsibility of a Dbfactory
    /// </summary>
    public interface IDbFactory
    {
        IDbContext Init();
    }
}
