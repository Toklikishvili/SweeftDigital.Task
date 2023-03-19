using SweeftDigital.Domain;
using SweeftDigital.Repository;
using SweeftDigital.Repository.Interfaces;

namespace Test;

public class TeacherRepositoryTest
{
    private readonly ITeacherReposytory _teacherReposytory;
    public TeacherRepositoryTest()
    {
        _teacherReposytory = new TeacherRepository(MemoryDataBase.GetMemoryDatabase());
    }

    [Fact]
    public void SelectTest()
    {
        //
        var x = TeacherLoadData();
        foreach (var item in x)
        {
            _teacherReposytory.Insert(item);
        }
        _teacherReposytory.SaveChanges();

        //Act
        var teacher = _teacherReposytory.GetAllTeachersByStudent("Giorgi");

        //Assert
        Assert.True(teacher.Count() == 1);
    }

    public List<Teacher> TeacherLoadData()
    {
        var list = new List<Teacher>();

        list.Add(new Teacher()
        {
            FirstName = "Tamar",
            LastName = "Tamarashvili",
            Gender = "Female",
            Subject = "C#",
            Pupils = new List<Pupil>
            {
                new Pupil()
                {
                    FirstName = "გიორგი",
                    LastName = "სვანიძე",
                    Gender = "Male",
                    Class = "A"
                }
            }
        });

        list.Add(new Teacher()
        {
            FirstName = "Davit",
            LastName = "Davitashvili",
            Gender = "Male",
            Subject = "C++"
        });

        list.Add(new Teacher()
        {
            FirstName = "Mea",
            LastName = "Meadze",
            Gender = "Female",
            Subject = "ML",
            Pupils = new List<Pupil>
            {
                  new Pupil()
                {
                    FirstName = "გიორგი",
                    LastName = "გიორგაძე",
                    Gender = "Male",
                    Class = "A"
                },
                 new Pupil()
                {
                    FirstName = "გიორგი",
                    LastName = "სამხარძე",
                    Gender = "Male",
                    Class = "A"
                },
                  new Pupil()
                {
                    FirstName = "ირაკლი",
                    LastName = "ირაკლიშვილი",
                    Gender = "Male",
                    Class = "A"
                },
                   new Pupil()
                {
                    FirstName = "ანა",
                    LastName = "ანანიძე",
                    Gender = "Male",
                    Class = "A"
                }
            }
        });
        return list;
    }
}