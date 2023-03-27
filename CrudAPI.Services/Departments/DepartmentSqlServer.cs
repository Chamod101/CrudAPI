using CrudAPI.DataAccess;
using CrudAPI.Models;
using CrudAPI.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Departments
{
    public class DepartmentSqlServer : IDepartmentRepository
    {
        private readonly EmployeeDbContext _employeeDbContext =new EmployeeDbContext();
        public List<Department> departments()
        {
            return _employeeDbContext.departments.ToList();
        }

        public Department GetDepartment(Guid id)
        {
            return _employeeDbContext.departments.Find(id);
        }

        public Department AddDepartment(Department department)
        {
            _employeeDbContext.departments.Add(department);
            SaveChanges();
            return department;
        }

        public void SaveChanges()
        {
            _employeeDbContext.SaveChanges();
        }

        public Department FindId(Guid id)
        {
            return _employeeDbContext.departments.Find(id);
        }

        public void Remove(Department department)
        {
            _employeeDbContext.Remove(department);
            SaveChanges();
        }
    }
}
