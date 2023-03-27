using CrudAPI.DataAccess;
using CrudAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Employees
{
    public class EmployeeSqlService : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext = new EmployeeDbContext();

        public List<Employee> AllEmployees()
        {
            return _employeeDbContext.employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeDbContext.employees.Find(id);
        }
    }
}
