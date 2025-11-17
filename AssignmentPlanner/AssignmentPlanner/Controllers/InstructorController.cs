using AssignmentPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentPlanner.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Create()
        {
            return View(new AssignmentViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AssignmentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            TempData["Message"] = "Assignment created successfully!";
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int id)
        {
            var example = new AssignmentViewModel
            {
                Id = id,
                Title = "Sample Assignment",
                Description = "Example description."
            };

            return View(example);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, AssignmentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            TempData["Message"] = "Assignment updated!";
            return RedirectToAction("Edit", new { id = id });
        }
    }
}
