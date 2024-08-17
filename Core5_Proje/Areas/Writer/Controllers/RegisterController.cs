using Core5_Proje.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;
        public RegisterController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WriterUser w = new WriterUser()
                {
                    Name = p.Vname,
                    SureName = p.Vsurename,
                    UserName = p.VUserName,
                    Email = p.VMail
                };
                if(p.VPassword==p.VConfirmPassword)
                {
                    var result = await _usermanager.CreateAsync(w, p.VPassword);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
           


            }
            return View();
        }
       
    }
}
//123456aA$
