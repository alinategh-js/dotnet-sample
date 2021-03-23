using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Asa.Lecture.Domain.Entity
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "First Name cannot exceed 20 characters.")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "First Name cannot exceed 20 characters.")]
        public string LastName { get; set; }
    }
}
