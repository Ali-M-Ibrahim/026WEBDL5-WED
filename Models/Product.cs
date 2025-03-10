﻿using System.ComponentModel.DataAnnotations;

namespace TPINCIWED.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public double price { get; set; }
    }
}
