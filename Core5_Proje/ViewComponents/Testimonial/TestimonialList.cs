using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialmanager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            return View(testimonialmanager.TGetByList());
        }

    }
}
