using CrudAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Departments
{
    public interface IDepartmentRepository
    {
        public List<Department> departments();

        public Department GetDepartment(Guid id);

        public Department AddDepartment(Department department);
    }
}
