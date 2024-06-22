using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;
        public ProfileController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
    }
}
