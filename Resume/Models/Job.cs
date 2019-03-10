using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Job
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Please Your Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Please Your Title")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please Your Address ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Your Number ")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please enter Start Date")]
        public Nullable<System.DateTime> FromYear { get; set; }

        [Required(ErrorMessage = "Please enter End Date")]
        public Nullable<System.DateTime> ToYear { get; set; }

        public int ApplicantID { get; set; }
        public Applicant Applicant { get; set; }

     public Workexperience Workexperiences { get; set; }

    }
}