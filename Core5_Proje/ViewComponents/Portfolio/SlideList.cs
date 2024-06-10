using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Portfolio
{
    public class SlideList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.TGetByList();
            return View(values);
        }
    }
}

