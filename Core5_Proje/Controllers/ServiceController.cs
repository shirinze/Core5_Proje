using BuinessLayer.Concreate;
using BuinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Core5_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager servicemaneger = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            return View(servicemaneger.TGetByList());
        }
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);
            if(results.IsValid)
            {
                servicemaneger.TAdd(service);
                return RedirectToAction("Index", "Service");
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
        public IActionResult DeleteService(int id)
        {
            var value = servicemaneger.TGetById(id);
            servicemaneger.TDelete(value);
            return RedirectToAction("Index", "Service");
        }
        public IActionResult UpdateService(int id)
        {
            return View(servicemaneger.TGetById(id));
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);
            if (results.IsValid)
            {
                servicemaneger.TUpdate(service);
                return RedirectToAction("Index", "Service");
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
