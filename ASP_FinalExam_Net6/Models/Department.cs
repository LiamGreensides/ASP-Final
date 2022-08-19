using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ASP_FinalExam_Net6.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(0)]
        public int EmployeeCount { get; set; }
            
    }
}
