using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Asa.Lecture.Domain.Entity
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Lesson title cannot exceed 20 characters.")]
        public string Title { get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Credit should be between 1 and 4")]
        public int Credit { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }
    }
}
