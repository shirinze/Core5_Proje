using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            return View(portfoliomanager.TGetByList());
        }
    }
}
