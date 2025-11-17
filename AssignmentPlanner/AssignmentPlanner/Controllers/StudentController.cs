using Microsoft.AspNetCore.Mvc;

namespace AssignmentPlanner.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
