using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Applicant
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Your First Name ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Your Last Name ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Your Date Of Birth ")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Your Address ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Your Number ")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Your Email Address ")]
        public string Email { get; set; }


        public ICollection<Job >Job { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Skill>Skills { get; set; }
        public ICollection<Reference> References { get; set; }
      //public ICollection<Workexperience> Workexperiences { get; set; }
    }
}
