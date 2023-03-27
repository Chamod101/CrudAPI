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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=DESKTOP-N11AEAV; database=Company;TrustServerCertificate=true;Integrated Security=True ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                Salary = 100

                }
            });
        }
    }
}
