using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Task<Student> Add(Student student)
        {
            student.Id = _studentList.Max(s => s.Id) + 1;
            _studentList.Add(student);
            return Task.FromResult(student);
        }

        public Task<Student> Delete(int id)
        {
            var student = _studentList.FirstOrDefault(s => s.Id == id);
            if(student != null)
            {
                _studentList.Remove(student);
            }
            return Task.FromResult(student);
        }

        public Task<Student> Get(int id)
        {
            return Task.FromResult(_studentList.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await Task.FromResult(_studentList);
            return students;
        }

        public Task<Student> Update(Student studentChanges)
        {
            var student = _studentList.FirstOrDefault(s => s.Id == studentChanges.Id);
            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
            }
            return Task.FromResult(student);
        }
    }
}
