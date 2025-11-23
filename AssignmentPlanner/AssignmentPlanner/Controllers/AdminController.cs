using AssignmentPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssignmentPlanner.Controllers
{
    public class AdminController : Controller
    {
        private readonly AssignmentPlannerDbContext _context;

        public AdminController(AssignmentPlannerDbContext context)
        {
            _context = context;
        }

        public IActionResult AdministrationDashboard()
        {
            var assignments = _context.Assignments.ToList();
            return View(assignments);
        }

        public IActionResult Index()
        {
            var assignments = _context.Assignments.ToList();
            return View(assignments);
        }

        public IActionResult Edit(int id)
        {
            var assignment = _context.Assignments.FirstOrDefault(a => a.Id == id);
            if (assignment == null)
                return NotFound();

            return View(assignment);
        }

        [HttpPost]
        public IActionResult Edit(Assignment updated)
        {
            if (!ModelState.IsValid)
                return View(updated);

            _context.Assignments.Update(updated);
            _context.SaveChanges();

            TempData["Success"] = "Assignment updated successfully.";
            return RedirectToAction("AdministrationDashboard");
        }
    }
}
