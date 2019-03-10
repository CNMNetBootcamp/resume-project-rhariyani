using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Skill
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your skill name")]
        public string SkillName { get; set; }

        public int ApplicantID { get; set; }
        public Applicant Applicant { get; set; }

    }
}
