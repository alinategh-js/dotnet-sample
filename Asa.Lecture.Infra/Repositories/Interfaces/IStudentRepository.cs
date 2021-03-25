using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Infra.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> Get(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Add(Student student);
        Task<Student> Update(Student studentChanges);
        Task<Student> Delete(int id);
    }
}
