using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
