using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; } = string.Empty;
        [StringLength(25)]
        public string Code { get; set; } = string.Empty;
        public int SuccessGrade { get; set; }
        public int FailureGrade { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
