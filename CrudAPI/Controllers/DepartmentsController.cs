using AutoMapper;
using CrudAPI.Models;
using CrudAPI.Services.Departments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _service;
        
        public DepartmentsController(IDepartmentRepository service)
        {
            _service = service;
            
        }

        [HttpGet]
        public ActionResult<ICollection<Department>> GetDepartments()
        {
            var departments = _service.departments();

            

            return Ok(departments);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartment(Guid id)
        {
            var department =_service.GetDepartment(id);

            if(department is null)
            {
                return NotFound();
            };


            return Ok(department);
        }

        [HttpPost]
        public IActionResult AddnewDepartment(AddDepartments addDepartments)
        {
            var department = new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName = addDepartments.DepartmentName
            };

            var result = _service.AddDepartment(department);
            return Ok(result);
        }
    }
}
