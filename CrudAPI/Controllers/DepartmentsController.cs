using AutoMapper;
using CrudAPI.Models;
using CrudAPI.Services.Departments;
using CrudAPI.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _service;
        private readonly IMapper _mapper;
        public DepartmentsController(IDepartmentRepository service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<DepartmentDto>> GetDepartments()
        {
            var departments = _service.departments();

            var mapDepartments=_mapper.Map<ICollection<DepartmentDto>>(departments);

            return Ok(mapDepartments);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            var department =_service.GetDepartment(id);

            if(department is null)
            {
                return NotFound();
            };

            var mapDepartment = _mapper.Map<DepartmentDto>(department);

            return Ok(mapDepartment);
        }
    }
}
