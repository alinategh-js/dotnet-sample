using Asa.Lecture.Service.Interfaces;
using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Service.Implements
{
    public class StudentService : IStudentService
    {
        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            var student = new Student { FirstName = "Ali", Id = 1, LastName = "Nategh" };
            return student;
        }

        public Student Update(Student studentChanges)
        {
            throw new NotImplementedException();
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
