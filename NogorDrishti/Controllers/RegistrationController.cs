using Microsoft.AspNetCore.Mvc;
using NogorDrishti.Models;

namespace NogorDrishti.Controllers
{
    public class RegistrationController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
       public IActionResult Registration()
        {

            return View(new RegistrationModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(Models.RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}