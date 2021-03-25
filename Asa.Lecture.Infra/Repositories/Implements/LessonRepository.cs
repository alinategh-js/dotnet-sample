using Asa.Lecture.Domain.Entity;
using Asa.Lecture.Infra.DbContexts;
using Asa.Lecture.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.Repositories.Implements
{
    public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
    {
        public LessonRepository(LectureDBContext context) : base(context)
        {

        }
    }
}
