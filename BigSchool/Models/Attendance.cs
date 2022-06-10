using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Attendance
    {
        public Course Course { set; get; }
        [Key]
        [Column(Order = 1)]
        public int CourseId { set; get; }
        public ApplicationUser Attendee { set; get; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { set; get; }
    }
}