using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.DbContexts;
using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.Repositories.Implements
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly LectureDBContext _context;

        public SQLStudentRepository(LectureDBContext context)
        {
            _context = context;
        }
        public Student Add(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            var student = _context.Student.Find(id);
            if(student != null)
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public Student Get(int id)
        {
            return _context.Student.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Student;
        }

        public Student Update(Student studentChanges)
        {
            throw new NotImplementedException();
        }
    }
}
