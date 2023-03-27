using CrudAPI.Models;

namespace CrudAPI.Services.Employees
{
    public class EmployeeService : IEmployeeRepository
    {
        public List<Employee> AllEmployees()
        {
            var employees = new List<Employee>();

            var employee1 = new Employee
            {
                Id = 1,
                FirstName = "Chamod",
                LastName = "Perera",
                Email = "Chamod@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100
            };
            employees.Add(employee1);

            var employee2 = new Employee
            {
                Id = 2,
                FirstName = "DChamod",
                LastName = "Perera",
                Email = "Chamod@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100
            };
            employees.Add(employee2);

            var employee3 = new Employee
            {
                Id = 3,
                FirstName = "AmaChamod",
                LastName = "Perera",
                Email = "Chamod@gmail.com",
                DOB = DateTime.Now,
                Age = 10,
                Salary = 100
            };
            employees.Add(employee3);

            return employees;
        }
    }
}
