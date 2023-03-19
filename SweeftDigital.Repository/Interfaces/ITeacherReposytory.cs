using SweeftDigital.Domain;

namespace SweeftDigital.Repository.Interfaces;
public interface ITeacherReposytory : IRepositoryBase<Teacher>
{
    IEnumerable<Teacher> GetAllTeachersByStudent(string studentName);
}
