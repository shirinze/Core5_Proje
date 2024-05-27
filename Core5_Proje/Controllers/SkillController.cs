using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Skill";
            ViewBag.v2 = "skillist";
            ViewBag.v3 = "Skill";
            return View(skillmanager.TGetByList());
        }
        public IActionResult SkillAdd()
        {
            ViewBag.v1 = "Skill";
            ViewBag.v2 = "Addskill";
            ViewBag.v3 = "Skill";
            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(Skill skill)
        {
            skillmanager.TAdd(skill);
            
            return RedirectToAction("Index","Skill");
        }
        public IActionResult SkillDelete(int id)
        {
            var value = skillmanager.TGetById(id);
            skillmanager.TDelete(value);
            return RedirectToAction("Index");
        }


    }
}
