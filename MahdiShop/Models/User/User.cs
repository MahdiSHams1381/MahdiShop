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
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "کلمه عبور باید شامل حرف و عدد باشد")]

        public string Password { get; set; }
        [Compare("Password" , ErrorMessage = "your password rip is nor compair") ]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "کلمه عبور باید شامل حرف و عدد باشد")]
        [DataType(DataType.Password)]
        public string PasswordRip { get; set; }
    }
}
