using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TriFalcon_Fitness.Data;
using TriFalcon_Fitness.Models;

namespace TriFalcon_Fitness.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
    {
        _logger = logger;
        _userManager = userManager;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        return View(user);
    }

    public async Task<IActionResult> Settings()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Index");
        return View(user);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UpdateSettings(ApplicationUser model)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return NotFound();

        user.FullName = model.FullName;
        user.Weight = model.Weight;
        user.Height = model.Height;
        user.Age = model.Age;
        user.GoalWeight = model.GoalWeight;
        user.TargetExercise = model.TargetExercise;
        user.TargetStrengthWeight = model.TargetStrengthWeight;
        user.TargetCardioType = model.TargetCardioType;
        user.TargetDistance = model.TargetDistance;
        user.TargetDuration = model.TargetDuration;

        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            TempData["StatusMessage"] = "Profile and Goals updated successfully!";
            return RedirectToAction("Settings");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View("Settings", user);
    }

    public async Task<IActionResult> Progress()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Index");

        // FETCH ALL WORKOUTS: This ensures that whatever exercise name you type, 
        // the charts can find it and display it.
        var workouts = await _context.Workouts
            .Where(w => w.UserId == user.Id)
            .OrderBy(w => w.DateLogged)
            .ToListAsync();

        ViewBag.Workouts = workouts;
        return View(user);
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}