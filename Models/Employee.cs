using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud_Operation_in_mvc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string? EmpName { get; set; }
        [Required]
        public string? Designation { get; set; }
        [Required]
        public string? Technology { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public DateTime DateofJoining { get; set; }
        [Required]
        public string? Age { get; set; }
        [Required]
        public string? MobileNo { get; set; }

    }
}

