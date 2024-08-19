using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {

        MessageManager messagemanager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messagemanager.TGetByList().Take(5).ToList();
            return View(values);
        }
    }
}
