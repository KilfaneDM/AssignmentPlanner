using Microsoft.AspNetCore.Mvc;
using AssignmentPlanner.Models;
using System.Linq;

namespace AssignmentPlanner.Controllers
{
    public class AccountController : Controller
    {
        private readonly AssignmentPlannerDbContext _context;

        public AccountController(AssignmentPlannerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var login = _context.Logins
                .FirstOrDefault(l => l.Nbccid.ToString() == model.Username && l.Password == model.Password);

            if (login == null)
            {
                TempData["LoginError"] = "Username or password is incorrect.";
                return View(model);
            }

            switch (login.UserType)
            {
                case "S":
                    return RedirectToAction("Index", "StudentDashboard");
                case "I":
                    return RedirectToAction("Index", "InstructorDashboard");
                case "A":
                    return RedirectToAction("Index", "AdministrationDashboard");
                default:
                    TempData["LoginError"] = "Unknown user type.";
                    return View(model);
            }
        }s
    }
}