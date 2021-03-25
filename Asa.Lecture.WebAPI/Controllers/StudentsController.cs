using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Service.Interfaces;
using Asa.Lecture.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asa.Lecture.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _studentService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent([FromBody] Student student)
        {
            var stu = await _studentService.Add(student);
            return Ok(stu);
        }
    }
}
