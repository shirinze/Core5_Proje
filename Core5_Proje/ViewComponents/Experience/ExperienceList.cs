using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experiencemanager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            return View(experiencemanager.TGetByList());
        }
    }
}
