using CrudAPI.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Employees
{
    public interface IEmployeeRepository
    {
        public List<Employee> AllEmployees();

        public Employee GetEmployee(Guid id);

        public Employee AddEmployee(Employee employee);

        public Employee FindId(Guid id);
        public void SaveChanges();

        public void Remove(Employee employee);
    }
}
