using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "list";
            ViewBag.v3 = "Experience";
            return View(experiencemanager.TGetByList());
        }
        public IActionResult ExperienceAdd()
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Add";
            ViewBag.v3 = "Experience";
            return View();
        }
        [HttpPost]
        public IActionResult ExperienceAdd(Experience experience)
        {
            experiencemanager.TAdd(experience);
            return RedirectToAction("Index","Experience");
        }

        public IActionResult ExperienceDelete(int id)
        {
            var value = experiencemanager.TGetById(id);
            experiencemanager.TDelete(value);
            return RedirectToAction("Index","Experience");
        }
        public IActionResult ExperienceUpdate(int id)
        {
            ViewBag.v1 = "Experience";
            ViewBag.v2 = "Update";
            ViewBag.v3 = "Experience";
            return View(experiencemanager.TGetById(id));
        }
        [HttpPost]
        public IActionResult ExperienceUpdate(Experience experience)
        {
            experiencemanager.TUpdate(experience);
            return RedirectToAction("Index", "Experience");
        }
    }
}
