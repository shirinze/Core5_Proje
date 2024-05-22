using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
