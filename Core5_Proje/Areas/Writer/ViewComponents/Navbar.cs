using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core5_Proje.Areas.Writer.ViewComponents
{
    public class Navbar:ViewComponent
    {
        private readonly UserManager<WriterUser> _usermanger;
        public Navbar(UserManager<WriterUser> usermanger)
        {
            _usermanger = usermanger;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _usermanger.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.ImageUrl;
            return View();
        }
    }
}
