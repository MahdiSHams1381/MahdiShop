using System.ComponentModel.DataAnnotations;

namespace MahdiShop.Views.ViewModule
{
    public class SignInViewModule
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
