using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Teacher
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required please fill it")]
        public string Name { get; set; }

        [Required]
        public string Degree { get; set; } 
    }
}
