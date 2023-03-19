using Microsoft.AspNetCore.Mvc;
using SweeftDigital.Domain;
using SweeftDigital.Repository;
using SweeftDigital.Repository.Interfaces;
using SweeftDigitalTask.LocalStorage;
using Test;

namespace SweeftDigitalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherReposytory _teacherReposytory;
        public TeacherController(ITeacherReposytory teacherReposytory)
        {
            _teacherReposytory = teacherReposytory;
        }

        [HttpGet("GetAllTeachersByStudent")]
        public IEnumerable<Teacher> GetAllTeachersByStudent(string text)
        {
            return _teacherReposytory.GetAllTeachersByStudent(text);
        }

        [HttpGet("GetAllTeacher")]
        public IEnumerable<Teacher> GetAllTeacher()
        {
            return _teacherReposytory.Select();
        }

        [HttpPost("LoadTeacher")]
        public ActionResult LoadTeacher()
        {
            foreach (var item in LocalData.TeacherLoadData())
            {
                _teacherReposytory.Insert(item);
            }
            _teacherReposytory.SaveChanges();
            return Ok();
        }
    }
}
