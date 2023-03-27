namespace CrudAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public long Salary { get; set; }

        public int DepartmentId { get; set; }


        
    }
}
