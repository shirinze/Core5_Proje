using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "Admin@gmail.com";
            var values = writermessagemanager.GetListRecieverMessage(p).OrderByDescending(x => x.WriterMessageId).Take(3).ToList();
            return View(values);
        }
    }
}
