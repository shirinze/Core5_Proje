using System.ComponentModel.DataAnnotations;

namespace Core5_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="please enter the name.")]
        public string Vname { get; set; }

        [Required(ErrorMessage ="please enter the surename.")]
        public string Vsurename { get; set; }
        [Required(ErrorMessage ="please enter the imageurl.")]
        public string Vimageurl { get; set; }
        [Required(ErrorMessage = "please enter the username.")]
        public string VUserName { get; set; } 

        [Required(ErrorMessage ="please enter the password.")]
        public string VPassword { get; set; }

        [Required(ErrorMessage ="please enter the password again.")]
        [Compare("Password",ErrorMessage ="password not the same.")]
        public string VConfirmPassword { get; set; }

        [Required(ErrorMessage ="please enter the email")]
        public string VMail { get; set; }
    }
}
