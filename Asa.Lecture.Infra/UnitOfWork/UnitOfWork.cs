using Asa.Lecture.Infra.DbContexts;
using Asa.Lecture.Infra.Repositories.Implements;
using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LectureDBContext _context; // all repositories will use the same instace of context

        public UnitOfWork(LectureDBContext context, IStudentRepository studentRepository) // dependency injection
        {
            _context = context;
            StudentRepository = studentRepository; 
        }
        public IStudentRepository StudentRepository { get; }//=> new StudentRepository(_context);

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0; // any value greater than 0 means changes are made successfully
        }
    }
}
