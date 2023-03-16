using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MahdiShop.Models.Product
{
    public class Product
    {
        [Required]
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public List<string> Category { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
