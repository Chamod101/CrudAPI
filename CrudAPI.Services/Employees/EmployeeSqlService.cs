using CrudAPI.DataAccess;
using CrudAPI.Models.Employee;
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

        public Employee GetEmployee(Guid id)
        {
            return _employeeDbContext.employees.Find(id);
        }

        public Employee AddEmployee(Employee employee)
        {
            _employeeDbContext.employees.Add(employee);
            SaveChanges();
            return employee;
        }

        public void SaveChanges()
        {
            _employeeDbContext.SaveChanges();
        }

        public Employee FindId(Guid id)
        {
            return _employeeDbContext.employees.Find(id);
        }

        public void Remove(Employee employee)
        {
            _employeeDbContext.Remove(employee);
            SaveChanges();
        }

    }
}
