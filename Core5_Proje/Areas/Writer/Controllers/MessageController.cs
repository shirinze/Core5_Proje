using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _usermanager;
        public MessageController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IActionResult> RecieverMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writermessagemanager.GetListRecieverMessage(p);
            return View(messagelist);
        }
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writermessagemanager.GetListSenderMessage(p);
            return View(messagelist);
        }
        
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetById(id);
            return View(writermessage);
        }
        public IActionResult RecieverMessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetById(id);
            return View(writermessage);
        }

        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.SureName;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            writermessagemanager.TAdd(p);
            return RedirectToAction("SenderMessage","Message");
        }
    }
}
