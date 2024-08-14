using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core5_Proje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experiencemanager.TGetByList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experiencemanager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceID)
        {
            var result = experiencemanager.TGetById(ExperienceID);
            var values = JsonConvert.SerializeObject(result);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var result = experiencemanager.TGetById(id);
            experiencemanager.TDelete(result);
            return NoContent();
            
        }

      
    }
}
