using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonisalmanager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonisalmanager.TGetByList();
            return View(values);
        }

        public IActionResult TestimonialDelete(int id)
        {
            var values = testimonisalmanager.TGetById(id);
            testimonisalmanager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult TestimonialEdite(int id)
        {
            var values = testimonisalmanager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult TestimonialEdite(Testimonial p)
        {
            testimonisalmanager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
