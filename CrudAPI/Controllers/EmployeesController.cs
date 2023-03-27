using AutoMapper;
using CrudAPI.Models;
using CrudAPI.Services.Employees;
using CrudAPI.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository repository,IMapper mapper)
        {
            _employeeService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<EmployeeDto>> GetEmployees()
        {
            var myEmployees = _employeeService.AllEmployees();
            var mapEmployeess = _mapper.Map<ICollection<EmployeeDto>>(myEmployees);

            return Ok(mapEmployeess);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            if(employee == null)
            {
                return NotFound();
            }

            var mapEmployee = _mapper.Map<EmployeeDto>(employee);

            return Ok(mapEmployee);
        }

       
    }
}
