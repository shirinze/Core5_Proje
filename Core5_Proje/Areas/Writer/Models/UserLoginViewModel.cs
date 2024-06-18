using System.ComponentModel.DataAnnotations;

namespace Core5_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="user name")]
        [Required(ErrorMessage ="please enter the username!!!")]
        public string Username { get; set; }
        [Display(Name ="password")]
        [Required(ErrorMessage ="please enter the password!!!")]
        public string Passworde { get; set; }
    }
}
