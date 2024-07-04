using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterMessage> _usermanager;
        public MessageController(UserManager<WriterMessage> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index(string p)
        {
            var value = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = value.Sender;
            return View();
        }
    }
}
