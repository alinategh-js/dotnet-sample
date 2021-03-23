using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asa.Lecture.Infra.Repositories.Implements
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student{Id = 1, FirstName = "Ali", LastName= "Nategh"},
                new Student{Id = 2, FirstName = "Hossein", LastName= "Delavari"},
                new Student{Id = 3, FirstName = "Jafar", LastName = "Jafari"}
            };
        }
        public Student Add(Student student)
        {
            student.Id = _studentList.Max(s => s.Id) + 1;
            _studentList.Add(student);
            return student;
        }

        public Student Delete(int id)
        {
            var student = _studentList.FirstOrDefault(s => s.Id == id);
            if(student != null)
            {
                _studentList.Remove(student);
            }
            return student;
        }

        public Student Get(int id)
        {
            return _studentList.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentList;
        }

        public Student Update(Student studentChanges)
        {
            var student = _studentList.FirstOrDefault(s => s.Id == studentChanges.Id);
            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
            }
            return student;
        }
    }
}
