using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Models.Employee
{
    public class UpdateEmployee
    {


        [Required]
        [MaxLength(150)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(150)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(150)]
        public string? Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public long Salary { get; set; }
        [Required]
        public int DepartmentId { get; set; }

    }
}
