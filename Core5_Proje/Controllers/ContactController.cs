using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messagemanager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messagemanager.TGetByList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var values = messagemanager.TGetById(id);
            messagemanager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
