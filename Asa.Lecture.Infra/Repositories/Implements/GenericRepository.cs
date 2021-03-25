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
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly LectureDBContext _context;
        public GenericRepository(LectureDBContext context)
        {
            _context = context;
        }
        public Task<T> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return Task.FromResult(entity);
        }

        public Task<T> Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
            return Task.FromResult(entity);
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities;
        }

        public Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return Task.FromResult(entity);
        }
    }
}
