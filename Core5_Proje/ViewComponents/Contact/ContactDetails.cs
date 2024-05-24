using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            return View(contactmanager.TGetByList());
        }
    }
}
