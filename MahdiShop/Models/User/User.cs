using System.ComponentModel.DataAnnotations;

namespace MahdiShop.Models.User
{
    public class User
    {
        [Required]
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string UserPhone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
