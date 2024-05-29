using BuinessLayer.Concreate;
using BuinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
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
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if(results.IsValid)
            {
                portfoliomanager.TAdd(p);
                return RedirectToAction("Index", "Portfolio");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
            
        }
        public IActionResult DeletePorfolio(int id)
        {
          
               
                var values = portfoliomanager.TGetById(id);
                portfoliomanager.TDelete(values);
               
           

            return RedirectToAction("Index", "Portfolio");


        }
    }
}
