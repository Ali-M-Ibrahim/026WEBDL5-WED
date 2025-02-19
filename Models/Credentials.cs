using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Credentials
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}
