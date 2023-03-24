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
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "the password should have a to z and 1 to 9")]

        public string Password { get; set; }
        [Compare("Password" , ErrorMessage = "your password rip is nor compair") ]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,20}$", ErrorMessage = "the password should have a to z and 1 to 9")]
        [DataType(DataType.Password)]
        public string PasswordRip { get; set; }
    }
}
