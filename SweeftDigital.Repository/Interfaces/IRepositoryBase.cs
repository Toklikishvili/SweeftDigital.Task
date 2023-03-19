using System.Linq.Expressions;

namespace SweeftDigital.Repository.Interfaces;

public interface IRepositoryBase<TDomain> : IDisposable where TDomain : class
{
    IEnumerable<TDomain> Find(Expression<Func<TDomain, bool>> predicate);
    IEnumerable<TDomain> Select();
    void Insert(TDomain entity);
    int SaveChanges();
}
