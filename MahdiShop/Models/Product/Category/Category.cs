﻿using System.ComponentModel.DataAnnotations;

namespace MahdiShop.Models.Product.Category
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Discription { get; set; }
    }
}
