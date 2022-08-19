using System.ComponentModel.DataAnnotations;

namespace ASP_FinalExam_Net6.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool IsManager { get; set; }

        public virtual Department Department { get; set; }
    }
}
