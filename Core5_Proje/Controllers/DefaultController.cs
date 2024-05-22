using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
