using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager servicemanager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {

            return View(servicemanager.TGetByList());
        }
    }
}
