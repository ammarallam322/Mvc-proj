﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(MVCProjectContext))]
    [Migration("20250202122147_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.Property<int>("deptId")
                        .HasColumnType("int");

                    b.Property<int>("hours")
                        .HasColumnType("int");

                    b.Property<int>("minDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("deptId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MVC",
                            degree = 100,
                            deptId = 1,
                            hours = 30,
                            minDegree = 60
                        },
                        new
                        {
                            Id = 2,
                            Name = "C#",
                            degree = 100,
                            deptId = 2,
                            hours = 30,
                            minDegree = 60
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.CrsReslt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Crs_id")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<string>("degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trainee_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.HasIndex("trainee_id")
                        .IsUnique();

                    b.ToTable("courseResults");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maneger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SD",
                            maneger = "Eng Chrestein"
                        },
                        new
                        {
                            Id = 2,
                            Name = "OS",
                            maneger = "Eng Chrestein"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("crs_id")
                        .HasColumnType("int");

                    b.Property<int>("deptId")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("crs_id");

                    b.HasIndex("deptId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ammar",
                            address = "tala",
                            crs_id = 1,
                            deptId = 1,
                            imageUrl = "1.gif",
                            salary = 25000
                        },
                        new
                        {
                            Id = 2,
                            Name = "allam",
                            address = "tala",
                            crs_id = 1,
                            deptId = 1,
                            imageUrl = "2.png",
                            salary = 25000
                        },
                        new
                        {
                            Id = 3,
                            Name = "ali",
                            address = "tala",
                            crs_id = 1,
                            deptId = 2,
                            imageUrl = "4.gif",
                            salary = 25000
                        },
                        new
                        {
                            Id = 4,
                            Name = "ahmed",
                            address = "tala",
                            crs_id = 1,
                            deptId = 2,
                            imageUrl = "1.gif",
                            salary = 25000
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("deptId")
                        .HasColumnType("int");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("deptId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("WebApplication1.Models.Course", b =>
                {
                    b.HasOne("WebApplication1.Models.Department", "Department")
                        .WithMany("courses")
                        .HasForeignKey("deptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication1.Models.CrsReslt", b =>
                {
                    b.HasOne("WebApplication1.Models.Course", "course")
                        .WithMany("result")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Trainee", "Trainee")
                        .WithOne("result")
                        .HasForeignKey("WebApplication1.Models.CrsReslt", "trainee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainee");

                    b.Navigation("course");
                });

            modelBuilder.Entity("WebApplication1.Models.Instructor", b =>
                {
                    b.HasOne("WebApplication1.Models.Course", "Course")
                        .WithMany("instructors")
                        .HasForeignKey("crs_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Department", "Department")
                        .WithMany("instructors")
                        .HasForeignKey("deptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication1.Models.Trainee", b =>
                {
                    b.HasOne("WebApplication1.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("deptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication1.Models.Course", b =>
                {
                    b.Navigation("instructors");

                    b.Navigation("result");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Navigation("Trainees");

                    b.Navigation("courses");

                    b.Navigation("instructors");
                });

            modelBuilder.Entity("WebApplication1.Models.Trainee", b =>
                {
                    b.Navigation("result")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
