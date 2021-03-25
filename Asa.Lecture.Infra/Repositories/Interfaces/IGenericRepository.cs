using Asa.Lecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Lecture.Infra.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T student);
        Task<T> Update(T studentChanges);
        Task<T> Delete(int id);
    }
}
