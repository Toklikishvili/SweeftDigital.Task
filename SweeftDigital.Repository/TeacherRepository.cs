using SweeftDigital.DbConection;
using SweeftDigital.Domain;
using SweeftDigital.Repository.Interfaces;

namespace SweeftDigital.Repository;
internal class TeacherRepository : RepositoryBase<Teacher>, ITeacherReposytory
{
    public TeacherRepository(SweeftDigitalDbContext context) : base(context) { }
    public IEnumerable<Teacher> GetAllTeachersByStudent(string studentName)
    {
        var teachers = _context.Teachers
            .Where(t => t.Pupils.Any(p => p.FirstName == studentName))
            .ToList();

        return teachers;
    }
}