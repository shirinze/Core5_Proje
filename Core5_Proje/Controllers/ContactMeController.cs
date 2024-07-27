using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class ContactMeController : Controller
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactmanager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            contactmanager.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}
