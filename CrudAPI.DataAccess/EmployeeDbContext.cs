using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.DataAccess
{
    public class EmployeeDbContext :DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=DESKTOP-N11AEAV; database=Company;TrustServerCertificate=true;Integrated Security=True ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department[]
            {
                new Department{Id=1,DepartmentName="IT"},
                new Department{Id=2,DepartmentName="Marketing"},
                new Department{Id=3,DepartmentName="HR"},
                 new Department{Id=4,DepartmentName="Research"}
            });

            modelBuilder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee
                {
                Id = 1,
                FirstName = "Chamod DB",
                LastName = "Perera",
                Email = "Chamod@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100,
                DepartmentId=1
                

                },
                 new Employee
                {
                Id = 2,
                FirstName = "Amasha DB",
                LastName = "Perera",
                Email = "Amasha@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100,
                DepartmentId=3


                },
                 new Employee
                {
                Id = 3,
                FirstName = "Steve DB",
                LastName = "Perera",
                Email = "Amasha@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100,
                DepartmentId=2


                }
            });
        }
    }
}
