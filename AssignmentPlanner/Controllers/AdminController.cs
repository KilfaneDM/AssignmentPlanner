using Microsoft.AspNetCore.Mvc;

namespace AssignmentPlanner.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
