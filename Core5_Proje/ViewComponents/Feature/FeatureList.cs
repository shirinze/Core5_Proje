using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var value = featuremanager.TGetByList();
            return View(value);
        }
    }
}
