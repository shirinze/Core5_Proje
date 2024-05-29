using BuinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core5_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "PortfolioList";
            ViewBag.v3 = "Portfolio";
            return View(portfoliomanager.TGetByList());
        }

        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "PortfoliAdd";
            ViewBag.v3 = "Portfolio";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            portfoliomanager.TAdd(p);
            return RedirectToAction("Index", "Portfolio");
        }
    }
}
