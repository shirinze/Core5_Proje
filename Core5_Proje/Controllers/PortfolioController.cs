using BuinessLayer.Concreate;
using BuinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfoliomanager.TGetById(id);
            portfoliomanager.TDelete(values);
            return RedirectToAction("Index", "Portfolio");
        }

        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Portfolio";
            ViewBag.v2 = "updateportfolio";
            ViewBag.v3 = "Portfolio";
            var values = portfoliomanager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if(results.IsValid)
            {
                portfoliomanager.TUpdate(p);
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


    }
}
