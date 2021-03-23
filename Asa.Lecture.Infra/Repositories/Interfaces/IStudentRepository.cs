using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student Get(int id);
        IEnumerable<Student> GetAll();
        Student Add(Student student);
        Student Update(Student studentChanges);
        Student Delete(int id);
    }
}
