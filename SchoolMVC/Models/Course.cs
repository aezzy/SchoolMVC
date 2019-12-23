using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }

    
        public string CourseName { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher teacher { get; set; }
    }
}
