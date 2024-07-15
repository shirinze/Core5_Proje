using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutmanager = new AboutManager(new EfAboutDal());
        public IActionResult AboutUpdate()
        {
          
            var value = aboutmanager.TGetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            aboutmanager.TUpdate(about);
            return RedirectToAction("Index","Default");
        }
    }
}
