using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        SocialmediaManager socialmedia = new SocialmediaManager(new EfSocialMediaDal());
        public IViewComponentResult Invoke()
        {
            var values = socialmedia.TGetByList();
            return View(values);
        }
    }
}
