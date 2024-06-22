using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementmanager = new AnnouncementManager(new EfAnnounementDal());
        public IActionResult Index()
        {
            return View(announcementmanager.TGetByList());
        }

        public IActionResult AnnouncementDetail(int id)
        {
            return View(announcementmanager.TGetById(id));
        }
    }
}
