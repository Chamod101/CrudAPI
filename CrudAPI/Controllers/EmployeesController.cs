using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Employees()
        {
            var employees = new string[] { "emplyee1", "employee2", "employee3" };
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult NewEmployee()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteEmployee()
        {
            var somthingHappend = true;
            if (somthingHappend) return BadRequest();

            return Ok();
        }
    }
}
