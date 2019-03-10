using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Data
{

    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options)
            : base(options)
        {
        }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Workexperience> Workexperience { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.Entity<Applicant>().ToTable("Applicant");
            builder.Entity<Education>().ToTable("Education");
            builder.Entity<Reference>().ToTable("Reference");
            builder.Entity<Skill>().ToTable("Skill");
            builder.Entity<Job>().ToTable("Job");
            builder.Entity<Workexperience>().ToTable("Workexperience");
        }



    }
}
    
