using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MahdiShop.DataLayer.Models.Product
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> product { get; set; }
    }
}
