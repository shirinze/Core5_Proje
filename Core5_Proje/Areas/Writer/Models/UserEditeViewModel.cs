using Microsoft.AspNetCore.Http;

namespace Core5_Proje.Areas.Writer.Models
{
    public class UserEditeViewModel
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; } //root ıcınde kaydetmek ıcın
    }
}
