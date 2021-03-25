using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Domain.Entity
{
    public class StudentLesson
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
