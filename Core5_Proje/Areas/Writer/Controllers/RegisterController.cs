using Core5_Proje.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Areas.Writer.Controllers
{
    public class RegisterController : Controller
    {
        [Area("Writer")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterViewModel userviewmodel)
        {
            if(ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}
