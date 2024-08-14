using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}
