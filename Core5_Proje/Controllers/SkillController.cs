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
            return View(skillmanager.TGetByList());
        }
        public IActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(Skill s)
        {
            
            return View();
        }


    }
}
