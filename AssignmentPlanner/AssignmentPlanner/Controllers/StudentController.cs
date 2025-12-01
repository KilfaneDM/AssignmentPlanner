using Microsoft.AspNetCore.Mvc;
using AssignmentPlanner.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace AssignmentPlanner.Controllers
{
    public class StudentController : Controller
    {
        private readonly AssignmentPlannerDbContext _context;

        public StudentController(AssignmentPlannerDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult StudentDashboard()
        {
            var assignments = _context.Assignments.ToList();
            return View(assignments);
        }

        public IActionResult Index()
        {
            var assignments = _context.Assignments.ToList();
            return View(assignments);
        }
    }
}
