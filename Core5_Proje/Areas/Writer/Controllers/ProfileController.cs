using Core5_Proje.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;
        public ProfileController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            UserEditeViewModel model = new UserEditeViewModel();
            model.Name = values.Name;
            model.Surename = values.SureName;
            model.PictureUrl=values.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditeViewModel p)
        {
            //resim yukleme icin 
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            if(p.Picture!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/Userimage/" + imagename;
                var strem = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(strem);
                user.ImageUrl = imagename;
            }
            user.Name = p.Name;
            user.SureName = p.Surename;
            user.PasswordHash = _usermanager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _usermanager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
      
    }
}
