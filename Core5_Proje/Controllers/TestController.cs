using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
