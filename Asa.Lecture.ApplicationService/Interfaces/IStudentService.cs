using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Service.Interfaces
{
    public interface IStudentService
    {
        Student Add(Student student);
        Student Get(int id);
        IEnumerable<Student> GetAll();
        Student Update(Student studentChanges);
        Student Delete(int id);
    }
}
