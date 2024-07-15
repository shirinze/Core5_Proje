using BuinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _usermanager;
        public MessageController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        [Route("")]
        [Route("RecieverMessage")]
        public async Task<IActionResult> RecieverMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writermessagemanager.GetListRecieverMessage(p);
            return View(messagelist);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writermessagemanager.GetListSenderMessage(p);
            return View(messagelist);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetById(id);
            return View(writermessage);
        }
        [Route("RecieverMessageDetails/{id}")]
        public IActionResult RecieverMessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetById(id);
            return View(writermessage);
        }
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.SureName;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurename = c.Users.Where(x => x.Email == p.Reciever).Select(y => y.Name + " " + y.SureName).FirstOrDefault();
            p.RecieverName = usernamesurename;
            writermessagemanager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
