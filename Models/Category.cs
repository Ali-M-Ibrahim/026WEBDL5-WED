using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please we need to have the name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
