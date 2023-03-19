using Microsoft.EntityFrameworkCore;
using SweeftDigital.DbConection;
using SweeftDigital.Repository.Interfaces;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Test")]
[assembly: InternalsVisibleTo("SweeftDigitalTask")]
namespace SweeftDigital.Repository;
internal abstract class RepositoryBase<TDomain> : IRepositoryBase<TDomain> where TDomain : class
{
    protected readonly SweeftDigitalDbContext _context;
    protected RepositoryBase(SweeftDigitalDbContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    public virtual IEnumerable<TDomain> Find(Expression<Func<TDomain, bool>> predicate) =>
         _context.Set<TDomain>().Where(predicate).ToList();
    public virtual void Insert(TDomain entity) => _context.Set<TDomain>().Add(entity);
    public virtual IEnumerable<TDomain> Select() => _context.Set<TDomain>();
    public int SaveChanges() => _context.SaveChanges();
    public virtual void Dispose() => _context?.Dispose();
}