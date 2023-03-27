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
        public IActionResult GetEmployees()
        {
            var myEmployees = _employeeService.AllEmployees();
            
            return Ok(myEmployees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

       
    }
}
