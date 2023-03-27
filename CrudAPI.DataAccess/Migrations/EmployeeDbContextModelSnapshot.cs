﻿// <auto-generated />
using System;
using CrudAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudAPI.DataAccess.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudAPI.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentName = "Research"
                        });
                });

            modelBuilder.Entity("CrudAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 10,
                            DOB = new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4105),
                            DepartmentId = 1,
                            Email = "Chamod@gmail.com",
                            FirstName = "Chamod DB",
                            LastName = "Perera",
                            Salary = 100L
                        },
                        new
                        {
                            Id = 2,
                            Age = 10,
                            DOB = new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4121),
                            DepartmentId = 3,
                            Email = "Amasha@gmail.com",
                            FirstName = "Amasha DB",
                            LastName = "Perera",
                            Salary = 100L
                        },
                        new
                        {
                            Id = 3,
                            Age = 10,
                            DOB = new DateTime(2023, 3, 27, 11, 59, 59, 977, DateTimeKind.Local).AddTicks(4124),
                            DepartmentId = 2,
                            Email = "Amasha@gmail.com",
                            FirstName = "Steve DB",
                            LastName = "Perera",
                            Salary = 100L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
