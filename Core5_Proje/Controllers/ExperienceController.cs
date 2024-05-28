using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View(experiencemanager.TGetByList());
        }
    }
}
