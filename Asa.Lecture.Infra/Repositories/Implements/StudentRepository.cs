using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.DbContexts;
using Asa.Lecture.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Infra.Repositories.Implements
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LectureDBContext _context;

        public StudentRepository(LectureDBContext context)
        {
            _context = context;
        }
        public Task<Student> Add(Student student)
        {
            _context.Student.Add(student);
            return Task.FromResult(student);
        }

        public Task<Student> Delete(int id)
        {
            var student = _context.Student.Find(id);
            if(student != null)
            {
                _context.Student.Remove(student);
            }
            return Task.FromResult(student);
        }

        public async Task<Student> Get(int id)
        {
            var student = await _context.Student.FindAsync(id);
            return student;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _context.Student.ToListAsync();
            return students;
        }

        public async Task<Student> Update(Student studentChanges)
        {
            var student = await _context.Student.FindAsync(studentChanges.Id);
            if(student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
            }
            return student;
        }
    }
}
