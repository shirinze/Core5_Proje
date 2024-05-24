using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messagemanager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
