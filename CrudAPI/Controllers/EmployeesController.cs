
using CrudAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public EmployeesController(IEmployeeRepository repository)
        {
            _employeeService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetEmployees(int? id)
        {
            var myEmployees = _employeeService.AllEmployees();
            if (id is null) return Ok(myEmployees);

            myEmployees=myEmployees.Where(t => t.Id == id).ToList();
            return Ok(myEmployees);
        }

       
    }
}
