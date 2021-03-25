using Asa.Lecture.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.Lecture.Infra.DbContexts
{
    public class LectureDBContext : DbContext
    {
        public LectureDBContext(DbContextOptions<LectureDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentLesson>().HasKey(sc => new { sc.StudentId, sc.LessonId });
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<StudentLesson> StudentLesson { get; set; }
    }
}
