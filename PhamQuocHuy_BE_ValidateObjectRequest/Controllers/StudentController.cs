using Microsoft.AspNetCore.Mvc;
using PhamQuocHuy_BE_ValidateObjectRequest.Model;
using System.Collections.Generic;

namespace PhamQuocHuy_BE_ValidateObjectRequest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>();

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            students.Add(student);

            return Ok($"Đã thêm {student.FullName} vào danh sách");
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }

        [HttpGet("{name}")]
        public IActionResult GetStudent(string name)
        {
            var student = students.FirstOrDefault(s => s.FullName == name);

            if (student == null)
            {
                return NotFound("Student not found.");
            }

            return Ok(student);
        }
    }
}
