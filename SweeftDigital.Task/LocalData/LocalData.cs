using SweeftDigital.Domain;

namespace SweeftDigitalTask.LocalStorage
{
    public class LocalData
    {
        public static List<Teacher> TeacherLoadData()
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
                    Gender = "Female",
                    Class = "A"
                }
            }
            });
            return list;
        }
    }
}
