﻿using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

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
