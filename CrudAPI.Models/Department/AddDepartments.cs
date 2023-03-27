using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Models.Department
{
    public class AddDepartments
    {
        [Required]
        [MaxLength(150)]
        public string? DepartmentName { get; set; }
    }
}
