using System.ComponentModel.DataAnnotations;

namespace Core5_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="please enter the username.")]
        public string UserName { get; set; } 

        [Required(ErrorMessage ="please enter the password.")]
        public string Password { get; set; }

        [Required(ErrorMessage ="please enter the password again.")]
        [Compare("Password",ErrorMessage ="password not the same.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="please enter the email")]
        public string Mail { get; set; }
    }
}
