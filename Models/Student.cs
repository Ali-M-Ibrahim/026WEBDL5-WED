using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }


        [Required]
        public string Lastname { get; set; }

        public Credentials Credentials { get; set; }    
    }
}
