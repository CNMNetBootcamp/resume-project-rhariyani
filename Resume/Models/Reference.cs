using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Reference
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Your First Name ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Your Last Name ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Your Company Name ")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please Your Position Name ")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please Your Address ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Your Number ")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Your Email Address ")]
        public string Email { get; set; }

        public int ApplicantID { get; set; }

        public Applicant Applicant { get; set; }
    }
}


