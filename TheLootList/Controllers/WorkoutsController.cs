using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TriFalcon_Fitness.Data;
using TriFalcon_Fitness.Models;

namespace TriFalcon_Fitness.Controllers;

public class WorkoutsController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public WorkoutsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: Workouts
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return Challenge();

        // Fetches only YOUR workouts, newest first
        var workouts = await _context.Workouts
            .Where(w => w.UserId == user.Id)
            .OrderByDescending(w => w.DateLogged)
            .ToListAsync();

        return View(workouts);
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
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return NotFound();

        // 1. Manually attach the logged-in User's ID and current timestamp
        workout.UserId = user.Id;
        workout.DateLogged = DateTime.Now;

        // 2. CRITICAL: Remove validation for the User object so the save doesn't fail silently
        ModelState.Remove("UserId");
        ModelState.Remove("User");

        if (ModelState.IsValid)
        {
            _context.Add(workout);
            await _context.SaveChangesAsync();

            // Redirect to the list to confirm it saved
            return RedirectToAction(nameof(Index));
        }

        // If we reach here, there was a validation error (like a missing field)
        return View(workout);
    }

    // GET: Workouts/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();

        var workout = await _context.Workouts
            .FirstOrDefaultAsync(m => m.Id == id);

        if (workout == null) return NotFound();

        return View(workout);
    }

    // POST: Workouts/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var workout = await _context.Workouts.FindAsync(id);
        if (workout != null)
        {
            _context.Workouts.Remove(workout);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}