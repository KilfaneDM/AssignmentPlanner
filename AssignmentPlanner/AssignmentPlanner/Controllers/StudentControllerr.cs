using Microsoft.AspNetCore.Mvc;

namespace AssignmentPlanner.Controllers
{
    public class StudentControllerr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
