using Asa.Lecture.Service.Interfaces;
using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Asa.Lecture.Infra.UnitOfWork;

namespace Asa.Lecture.Service.Implements
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _uow;

        public StudentService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Student> Add(Student student)
        {
            var newStudent = await _uow.StudentRepository.Add(student);
            _uow.SaveChanges();
            return newStudent;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _uow.StudentRepository.GetAll();
            return students;
        }

        public async Task<Student> Get(int id)
        {
            var student = await _uow.StudentRepository.Get(id);
            return student;
        }

        public async Task<Student> Update(Student studentChanges)
        {
            var student = await _uow.StudentRepository.Update(studentChanges);
            _uow.SaveChanges();
            return student;
        }

        public async Task<Student> Delete(int id)
        {
            var student = await _uow.StudentRepository.Delete(id);
            _uow.SaveChanges();
            return student;
        }
    }
}
