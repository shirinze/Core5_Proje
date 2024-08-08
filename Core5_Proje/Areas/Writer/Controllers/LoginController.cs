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

    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signinmanager;
        public LoginController(SignInManager<WriterUser> signinmanager)
        {
            _signinmanager = signinmanager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if(ModelState.IsValid)
            {
                var result = await _signinmanager.PasswordSignInAsync(p.Username, p.Passworde, true, true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    ModelState.AddModelError("", "username or password incorrect");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signinmanager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
    }
}
//Admin01*
