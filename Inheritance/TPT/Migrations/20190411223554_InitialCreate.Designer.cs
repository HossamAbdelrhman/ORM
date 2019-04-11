﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPT;

namespace TPT.Migrations
{
    [DbContext(typeof(TPTContext))]
    [Migration("20190411223554_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TPT.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName");

                    b.Property<float>("Price");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TPT.LabCourse", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<string>("Location");

                    b.HasKey("CourseId");

                    b.ToTable("LabCourses");
                });

            modelBuilder.Entity("TPT.OnlineCourse", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<bool>("SelfPaced");

                    b.HasKey("CourseId");

                    b.ToTable("OnlineCourses");
                });

            modelBuilder.Entity("TPT.LabCourse", b =>
                {
                    b.HasOne("TPT.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TPT.OnlineCourse", b =>
                {
                    b.HasOne("TPT.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}