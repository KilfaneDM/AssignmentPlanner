using Microsoft.AspNetCore.Mvc;

namespace AssignmentPlanner.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
