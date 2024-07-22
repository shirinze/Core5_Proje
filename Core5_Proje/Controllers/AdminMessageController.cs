using BuinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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

        public IActionResult AdminMessageDetail(int id)
        {
            var values = writermessagemanager.TGetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = writermessagemanager.TGetById(id);
            writermessagemanager.TDelete(values);
           
            return RedirectToAction("SenderMessageList", "AdminMessage");
        }

        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "Admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var values = c.Users.Where(x => x.Email == p.Reciever).Select(y => y.Name + " " + y.SureName).FirstOrDefault();
            p.RecieverName = values;
            writermessagemanager.TAdd(p);
            return RedirectToAction("SenderMessageList", "AdminMessage");
        }
    }
}
