using CrudAPI.Models.Department;
using CrudAPI.Models.Employee;
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

        
    }
}
