using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
