using SweeftDigital.DbConection;
using SweeftDigital.Domain;

namespace SweeftDigital.Repository;

internal class PupilRepository : RepositoryBase<Pupil>, IPupilReposytory
{
    public PupilRepository(SweeftDigitalDbContext context) : base(context) { }
}
