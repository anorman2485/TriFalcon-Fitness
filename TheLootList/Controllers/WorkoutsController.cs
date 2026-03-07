using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; // Added for security
using System.Security.Claims;             // Added to get the User ID
using TriFalcon_Fitness.Data;
using TriFalcon_Fitness.Models;

namespace TriFalcon_Fitness.Controllers
{
    [Authorize] // This ensures only logged-in users can access these pages
    public class WorkoutsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkoutsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Workouts
        // Modified to only show workouts belonging to the logged-in user
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var myWorkouts = await _context.Workouts
                .Where(w => w.UserId == userId)
                .OrderByDescending(w => w.DateLogged)
                .ToListAsync();

            return View(myWorkouts);
        }

        // GET: Workouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workout = await _context.Workouts
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId);

            if (workout == null)
            {
                return NotFound();
            }

            return View(workout);
        }

        // GET: Workouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workouts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActivityType,ExerciseName,Weight,Sets,Reps,Distance,DurationMinutes")] Workout workout)
        {
            // Automatically assign the UserID and Date
            workout.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            workout.DateLogged = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(workout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workout);
        }

        // GET: Workouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id && w.UserId == userId);

            if (workout == null)
            {
                return NotFound();
            }
            return View(workout);
        }

        // POST: Workouts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActivityType,ExerciseName,Weight,Sets,Reps,Distance,DurationMinutes")] Workout workout)
        {
            if (id != workout.Id)
            {
                return NotFound();
            }

            // Re-assign protected properties that shouldn't be changed by the form
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            workout.UserId = userId;

            // To keep the original date, we'd usually fetch it from the DB first, 
            // but for now, we will ensure the UserId remains consistent.

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkoutExists(workout.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(workout);
        }

        // GET: Workouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workout = await _context.Workouts
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId);

            if (workout == null)
            {
                return NotFound();
            }

            return View(workout);
        }

        // POST: Workouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id && w.UserId == userId);

            if (workout != null)
            {
                _context.Workouts.Remove(workout);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkoutExists(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _context.Workouts.Any(e => e.Id == id && e.UserId == userId);
        }
    }
}