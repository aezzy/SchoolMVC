using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMVC.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

       
        public string FirstName { get; set; }

     
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + ", " + LastName; }
        }

        public virtual ICollection<Course> course { get; set; }
    }
}
