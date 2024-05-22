using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutmanager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var value = aboutmanager.TGetByList();
            return View(value);
        }
    }
}
