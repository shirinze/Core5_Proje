using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillmanager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            return View(skillmanager.TGetByList());
        }
    }
}
