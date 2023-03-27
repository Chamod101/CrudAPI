using AutoMapper;
using CrudAPI.Models;
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
                DepartmentId = addEmployee.DepartmentId
            };
            
            var result=_employeeService.AddEmployee(employee);
            return Ok(result);
        }

       
    }
}
