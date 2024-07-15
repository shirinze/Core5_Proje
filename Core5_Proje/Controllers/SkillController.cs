using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics;

namespace Core5_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            return View(skillmanager.TGetByList());
        }
        public IActionResult SkillAdd()
        {
     
            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(Skill skill)
        {
            skillmanager.TAdd(skill);
            
            return RedirectToAction("Index");
        }
        public IActionResult SkillDelete(int id)
        {
            var value = skillmanager.TGetById(id);
            skillmanager.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult SkillUpdate(int id)
        {
            return View(skillmanager.TGetById(id));
        }
        [HttpPost]
        public IActionResult SkillUpdate(Skill s)
        {
            skillmanager.TUpdate(s);
            return RedirectToAction("Index");
        }


    }
}
