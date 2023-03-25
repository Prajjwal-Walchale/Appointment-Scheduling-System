﻿// <auto-generated />
using System;
using AppointmentSchedulingSystem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppointmentSchedulingSystem.Migrations
{
    [DbContext(typeof(AppointmentDbContext))]
    [Migration("20221209150624_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Rescheduled_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Rescheduled_Slot")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.Bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Courses")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Slot_1")
                        .HasColumnType("int");

                    b.Property<int?>("Slot_2")
                        .HasColumnType("int");

                    b.Property<int?>("Slot_3")
                        .HasColumnType("int");

                    b.Property<int?>("Slot_4")
                        .HasColumnType("int");

                    b.Property<int?>("Slot_5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Slot_1");

                    b.HasIndex("Slot_2");

                    b.HasIndex("Slot_3");

                    b.HasIndex("Slot_4");

                    b.HasIndex("Slot_5");

                    b.HasIndex("Courses", "Date")
                        .IsUnique()
                        .HasFilter("[Courses] IS NOT NULL");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username", "Email")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL AND [Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2000, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            Password = "Admin@pass",
                            Phone = "8665698589",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.Appointments", b =>
                {
                    b.HasOne("AppointmentSchedulingSystem.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppointmentSchedulingSystem.Models.Bookings", b =>
                {
                    b.HasOne("AppointmentSchedulingSystem.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Courses");

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User_1")
                        .WithMany()
                        .HasForeignKey("Slot_1");

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User_2")
                        .WithMany()
                        .HasForeignKey("Slot_2");

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User_3")
                        .WithMany()
                        .HasForeignKey("Slot_3");

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User_4")
                        .WithMany()
                        .HasForeignKey("Slot_4");

                    b.HasOne("AppointmentSchedulingSystem.Models.User", "User_5")
                        .WithMany()
                        .HasForeignKey("Slot_5");

                    b.Navigation("Course");

                    b.Navigation("User_1");

                    b.Navigation("User_2");

                    b.Navigation("User_3");

                    b.Navigation("User_4");

                    b.Navigation("User_5");
                });
#pragma warning restore 612, 618
        }
    }
}
