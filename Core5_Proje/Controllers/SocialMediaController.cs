using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialmediaManager socialmediamanager = new SocialmediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialmediamanager.TGetByList();
            return View(values);
        }
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            socialmediamanager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialmediamanager.TGetById(id);
            socialmediamanager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSocialMedia(int id)
        {
            var values = socialmediamanager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            socialmediamanager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
