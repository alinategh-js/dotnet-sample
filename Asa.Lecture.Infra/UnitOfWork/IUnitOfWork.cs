using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        bool SaveChanges();
    }
}
