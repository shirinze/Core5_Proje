using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core5_Proje.Areas.Writer.ViewComponents
{
    public class Notification:ViewComponent
    {
        AnnouncementManager announcementmanager = new AnnouncementManager(new EfAnnounementDal());
        public IViewComponentResult Invoke()
        {
            return View(announcementmanager.TGetByList());
        }
    }
}
