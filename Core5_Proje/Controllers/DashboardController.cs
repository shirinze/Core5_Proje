using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
