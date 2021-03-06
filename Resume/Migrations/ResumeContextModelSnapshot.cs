﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Resume.Data;
using System;

namespace Resume.Migrations
{
    [DbContext(typeof(ResumeContext))]
    partial class ResumeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Models.Applicant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("Resume.Models.Education", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicantID");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Degree")
                        .IsRequired();

                    b.Property<DateTime?>("FromYear")
                        .IsRequired();

                    b.Property<string>("InstituteUniversity")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime?>("ToYear")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Resume.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("ApplicantID");

                    b.Property<string>("Company")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<DateTime?>("FromYear")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<DateTime?>("ToYear")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Resume.Models.Reference", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("ApplicantID");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("Resume.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicantID");

                    b.Property<string>("SkillName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Resume.Models.Workexperience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExperieceDescription");

                    b.Property<int>("JobID");

                    b.HasKey("ID");

                    b.HasIndex("JobID")
                        .IsUnique();

                    b.ToTable("Workexperience");
                });

            modelBuilder.Entity("Resume.Models.Education", b =>
                {
                    b.HasOne("Resume.Models.Applicant", "Applicant")
                        .WithMany("Educations")
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resume.Models.Job", b =>
                {
                    b.HasOne("Resume.Models.Applicant", "Applicant")
                        .WithMany("Job")
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resume.Models.Reference", b =>
                {
                    b.HasOne("Resume.Models.Applicant", "Applicant")
                        .WithMany("References")
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resume.Models.Skill", b =>
                {
                    b.HasOne("Resume.Models.Applicant", "Applicant")
                        .WithMany("Skills")
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resume.Models.Workexperience", b =>
                {
                    b.HasOne("Resume.Models.Job", "Job")
                        .WithOne("Workexperiences")
                        .HasForeignKey("Resume.Models.Workexperience", "JobID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
