using AutoMapper;
using CrudAPI.Models.Employee;
using CrudAPI.Services.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;
        

        public EmployeesController(IEmployeeRepository repository)
        {
            _employeeService = repository;
           
        }

        [HttpGet]
        public ActionResult<ICollection<Employee>> GetEmployees()
        {
            var myEmployees = _employeeService.AllEmployees();
            

            return Ok(myEmployees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeService.GetEmployee(id);
            if(employee == null)
            {
                return NotFound();
            }


            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddnewEmployee(AddEmployee addEmployee) 
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = addEmployee.FirstName,
                LastName = addEmployee.LastName,
                Email = addEmployee.Email,
                DOB = addEmployee.DOB,
                Age = addEmployee.Age,
                Salary = addEmployee.Salary,
                DepartmentName = addEmployee.DepartmentName
            };
            
            var result=_employeeService.AddEmployee(employee);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee([FromRoute]Guid id,UpdateEmployee updateEmployee)
        {
            var employee=_employeeService.FindId(id);

            if(employee != null)
            {
                employee.FirstName = updateEmployee.FirstName;
                employee.LastName = updateEmployee.LastName;
                employee.Email = updateEmployee.Email;
                employee.DOB = updateEmployee.DOB;
                employee.Age = updateEmployee.Age;
                employee.Salary = updateEmployee.Salary;
                employee.DepartmentName = updateEmployee.DepartmentName;

                _employeeService.SaveChanges();
                return Ok(employee);
            }

            return NotFound();
        }


        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee([FromRoute] Guid id)
        {
            var employee = _employeeService.FindId(id);

            if (employee != null)
            {
                _employeeService.Remove(employee);
                return Ok(employee);
            }

            return NotFound();
        }
    }
}
