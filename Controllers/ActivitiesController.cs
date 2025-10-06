using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActivityTracker.Data;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Activities
        public async Task<IActionResult> Index()
        {
            var activities = await _context.Activities
                .OrderByDescending(a => a.Date)
                .ToListAsync();
            return View(activities);
        }

        // GET: /Activities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Activities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Activity activity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activity);
        }
    }
}