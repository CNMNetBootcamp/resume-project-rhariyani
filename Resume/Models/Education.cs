using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Education
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Your Institute or university")]
        public string InstituteUniversity { get; set; }

        [Required(ErrorMessage = "Please Your Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Your Degree")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Please enter Start Year")]
        public Nullable<System.DateTime> FromYear { get; set; }

        [Required(ErrorMessage = "Please enter End Year")]
        public Nullable<System.DateTime> ToYear { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        public int ApplicantID { get; set; }
        public Applicant Applicant { get; set; }

    }
}
