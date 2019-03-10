using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Resume.Data;
using Resume.Models;

namespace Resume.Data
{
    public class DbInitializer
    {
        public static void Initialize(ResumeContext context)
        {
            //context.Database.EnsureCreated();

            if (context.Applicant.Any())
            {
                return;   // DB has been seeded


            }

            //later
            if (context.Applicant.Any())
            {

                foreach (var applicants in context.Applicant)
                {

                    context.Applicant.Remove(applicants);
                }
                context.SaveChanges();
                AddApplicant(context);
            }
            else
            {
                AddApplicant(context);
            }

            if (context.Education.Any())
            {
                foreach (var educations in context.Education)
                {
                    context.Education.Remove(educations);
                }
                context.SaveChanges();
                AddEducation(context);

            }

            else
            {
                AddEducation(context);
            }

            if (context.Reference.Any())
            {
                foreach (var refernces in context.Reference)
                {
                    context.Reference.Remove(refernces);
                }
                context.SaveChanges();
                AddReference(context);
            }
            else
            {
                AddReference(context);
            }
          
            if (context.Job.Any())
            {
                foreach (var jobs in context.Job)
                {
                   
                    context.Job.Remove(jobs);
                }
                context.SaveChanges();
                AddJob(context);
            }
            else
            {
                AddJob(context);
            }
            if (context.Workexperience.Any())
            {
                foreach (var works in context.Workexperience)
                {
                    context.Workexperience.Remove(works);
                }
                context.SaveChanges();
                AddWorkexperience(context);
            }
            else
            {
                AddWorkexperience(context);
            }


            if (context.Skill.Any())
            {
                foreach (var skills in context.Skill)
                {
                    context.Skill.Remove(skills);
                }
                context.SaveChanges();
                AddSkill(context);
            }
            else
            {
                AddSkill(context);
            }

        }
        private static void AddApplicant(ResumeContext context)
        {
            var applicants = new Applicant[]
               {
                new Applicant { FirstName = "Rishita",   LastName = "Hariyani",
                    DateOfBirth = DateTime.Parse("1987-10-23") ,
                    Address ="1722 Vista del Norte Rd NM ",
                    Contact ="5053132020",
                    Email=" rishita.hariyani@gmail.com"
                    },
                };
            foreach (Applicant a in applicants)
            {
                context.Applicant.Add(a);
            }
            context.SaveChanges();
        }

        private static void AddEducation(ResumeContext context)
        {

            var educations = new Education[]
            {
                new Education { InstituteUniversity="XICA",
                    Title ="Computer Application",
                    Degree ="Bachelor's",
                    FromYear=DateTime.Parse("2005-03-11"),
                    ToYear = DateTime.Parse("2009-03-11"),
                    City="Ahmnedabad",
                    Country="India",
                     ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID
                  },
                new Education { InstituteUniversity="Lokmanya",
                    Title ="B.ED",
                    Degree ="Bachelor's",
                    FromYear=DateTime.Parse("2010-03-06"),
                    ToYear = DateTime.Parse("2011-04-05"),
                    City="Ahmnedabad",
                    Country="India",
                ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID

                  },
            };
            foreach (Education e in educations)
            {

                context.Education.Add(e);
            }
            context.SaveChanges();
        }


        private static void AddReference(ResumeContext context)
        {
            var references = new Reference[]
            {
                    new Reference
                    { FirstName = "Rimple",   LastName = "Chisrtian",
                    Position="Supervisor" ,
                    CompanyName="St.Kabir",
                    Address ="Naranpura India ",
                    Contact ="9898334682",
                    Email=" rimple.Chris@yahoo.com",
                   ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID

                    },

                    new Reference
                    { FirstName = "Jasmin",   LastName = "Panchal",
                    Position="VB Coder" ,
                    CompanyName="Prathama",
                    Address ="Gurukul Ahmedabad India ",
                    Contact ="9898225566",
                    Email=" Jass.p@yahoo.com",
               ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID
                },

            };
            foreach (Reference r in references )
            {
                context.Reference.Add(r);
            }
            context.SaveChanges();
        }
        private static void AddJob(ResumeContext context)
        {
            var jobs = new Job[]
        {
                new Job {
                Company="VFS",
                Position="Office",
                FromYear=DateTime.Parse("2014-04-10"),
                ToYear = DateTime.Parse("2015-07-11"),
                Address ="Ashram Road Ahmedabad India ",
                Contact ="3800923",
             ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
             //Workexperience= context.Workexperience.FirstOrDefault(i => i.ExperieceDescription=="A")
            
                },
                  new Job {
                Company="MVD EXPRESS",
                Position=" Customer Service Agent / VIN-Inspector ",
                FromYear=DateTime.Parse("2018-02-10"),
                ToYear = DateTime.Parse("2018-05-11"),
                Address ="Rio Rancho NM528 ",
                Contact ="5058412222",
             ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
                  },

                   new Job {
                Company="Walgreens",
                Position=" Customer Service Associate ",
                FromYear=DateTime.Parse("2016-01-10"),
                ToYear = DateTime.Parse("2016-06-11"),
                Address ="Rio Rancho Enchanted Hills ",
                Contact ="5051772777",
             ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
                  },
                    new Job {
                Company="Self Employed",
                Position="Private Tutor  ",
                FromYear=DateTime.Parse("2011-01-10"),
                ToYear = DateTime.Parse("2013-06-11"),
                Address =" 11 BOI society Ahmedabad-India ",
                Contact ="505313200000",
             ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
                  },


                new Job {
                Company="Stkabir",
                Position="Teacher",
                FromYear=DateTime.Parse("2009-06-11"),
                ToYear = DateTime.Parse("2011-06-11"),
                Address ="Navrangpura Ahmedabad India ",
                Contact ="9898225566",
                 ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
             //Workexperience= context.Workexperience.Single(w => w.ExperieceDescription=="School Teacher and admin").ID
                },
                 new Job {
                Company="AeroParts Manufacturing & Repair Inc",
                Position="Repair Customer Service Representative & Clerical Support ",
                FromYear=DateTime.Parse("2010-03-11"),
                ToYear = DateTime.Parse("2013-03-11"),
                Address ="Rio Rancho ",
                Contact ="5058005333",
                 ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID,
                 }
    };
            foreach (Job j in jobs)
            {
                    context.Job.Add(j);
                }
            
            context.SaveChanges();
        }
        private static void AddWorkexperience(ResumeContext context)

        {
            var works = new Workexperience[]
        {
                new Workexperience
                {
                    JobID = 1,
               ExperieceDescription ="Provided administrative & management support to the Canadian visa processing unit."
               +"Provided visa application processing services; verification, guidance and collection from individuals seeking a visa as per the embassy guidelines."+
               "Preparing monthly and quarterly reports, assisting the supervisor with daily office operations."

                },
                
                 new Workexperience
                {
                    JobID =2, 
               ExperieceDescription="Assist customers with motor vehicle needs --- walk in and/or by telephone.  "+
               "Communicate Effectively with Different Types of Customers."+ " Review Documents for Accuracy and Compliance." 
                },
          
                  new Workexperience
                {
                    JobID =3, 
               ExperieceDescription= "Work in a busy drugstore and gaining hands-on knowledge of retail pharmacy operations."
                + " Contributed to the customer service experience Educate and enlighten customers on product prices and details."
                 +"Processed forms, orders, applications, and requests made by customers."
                  },
                   new Workexperience
                {
                    JobID =4,
               ExperieceDescription= "Worked with students aged 7-13 to improve Science, English and Math. "
                +" Taught computer software like, Microsoft Excel, Word, Adobe Photoshop, HTML etc. " 
               +"Managed overall business revenue, expenses and regulatory requirements. "
                },
                  
                 new Workexperience
                {
                    JobID = 5,
               ExperieceDescription =" Served as the educational leader of the school specifically in regard to classroom management and student behavior.   " +"Aligned the educational programs, planed and actions to the district’s vision and goals for student learning; communicates to staff and community. "

            +"Provided research data and direction in developing and maintaining the best possible educational programs that optimize available human and material resources while working with supervisor to assist in the effective operation of the school."

            +"Aligned the educational programs, planed and actions to the district’s vision and goals for student learning; communicates to staff and community.  "
                },

                  new Workexperience
                {
                    JobID = 6,
               ExperieceDescription ="Assisting the engineering department with details on work orders and its specific job functions to perform on the part as requested by the customers." 
             +"Developed new process in Microsoft Excel for the Engineering and shipping department which created a standardized process for all the departments, eliminating confusions and miscommunications."
               +"Assisting the airline companies in processing work orders, maintaining high level of customer satisfaction by responding in a timely fashion via phone and email."
                },
                     
               
                };

            foreach (Workexperience w in works)
            {
                context.Workexperience.Add(w);
            }
            context.SaveChanges();
        }





        private static void AddSkill(ResumeContext context)
        {

            var skills = new Skill[]
                {
                new Skill {SkillName="Languages:C++, Visual Basic .net, SQL,Java, XML, HTML",
              ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID

                },
                new Skill {SkillName=" Software: Microsoft Project Management, Microsoft Suite, Macromedia Flash, Microsoft Front Page",
               ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID

                },
               new Skill  {SkillName="Systems: Windows, Linux, UNIX",
           ApplicantID  = context.Applicant.Single( i => i.FirstName == "Rishita").ID
}
                };
            foreach (Skill s in skills)
            {
                context.Skill.Add(s);
            }
            context.SaveChanges();

        }
        

    }
}




