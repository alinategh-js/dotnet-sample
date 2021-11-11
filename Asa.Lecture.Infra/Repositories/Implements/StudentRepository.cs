using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.DbContexts;
using Asa.Lecture.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Infra.Repositories.Implements
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(LectureDBContext context) : base(context) { }
        
        public IEnumerable<Student> GetByFirstName(string firstName)
        {
            var students = _context.Student
                .Where(s => s.FirstName == firstName)
                .OrderBy(x => x.Id)
                .ToList();

            return students;
        }
    }
}
