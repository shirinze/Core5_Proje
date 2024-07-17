using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult RecieverMessageList()
        {
            string p;
            p = "Admin@gmail.com";
            var values = writermessagemanager.GetListRecieverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "Admin@gmail.com";
            var values = writermessagemanager.GetListSenderMessage(p);
            return View(values);
        }
    }
}
