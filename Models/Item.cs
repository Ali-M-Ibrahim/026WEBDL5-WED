using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }        

    }
}
