using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager usermessagemanager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var value = usermessagemanager.GetUserMessageWithUserService();
            return View(value);
        }
    }
}
