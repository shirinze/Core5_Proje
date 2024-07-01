using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core5_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;
        public DashboardController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.SureName;

            //weather Api
            string api = "ccf865ffe892494f0c88190d76031544";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context c = new Context();

            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();
            return View();

        }
    }

}
//https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=ccf865ffe892494f0c88190d76031544
