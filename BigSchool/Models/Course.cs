using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { set; get; }

        public ApplicationUser Lecturer { set; get; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { set; get; }
        public DateTime DateTime { set; get; }
        public Category Category { set; get; }
        [Required]
        public byte CategoryId { set; get; }
    }
}