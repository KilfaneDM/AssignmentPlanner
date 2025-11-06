using Microsoft.AspNetCore.Mvc;
using AssignmentPlanner.Models;
namespace AssignmentPlanner.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // For now, just show what was entered or redirect somewhere.
                ViewBag.Message = $"You entered Username: {model.Username}, Password: {model.Password}";
                // You could redirect instead:
                // return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
