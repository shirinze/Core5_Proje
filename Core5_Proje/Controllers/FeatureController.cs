using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        public IActionResult UpdateFeature()
        {
      
            var result = featuremanager.TGetById(1);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            featuremanager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
