using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TriFalcon_Fitness.Models;

namespace TriFalcon_Fitness.Controllers;

[Authorize(Roles = "Admin")] // Security Layer: Only Admins can access these actions
public class AdminController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    // GET: /Admin
    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        return View(users);
    }

    // POST: /Admin/DeleteUser/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteUser(string id)
    {
        if (string.IsNullOrEmpty(id)) return NotFound();

        var user = await _userManager.FindByIdAsync(id);
        if (user == null) return NotFound();

        // Safety Check: Prevent Admin from deleting their own logged-in account
        var currentUser = await _userManager.GetUserAsync(User);
        if (currentUser?.Id == id)
        {
            return BadRequest("You cannot delete your own administrative account.");
        }

        var result = await _userManager.DeleteAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Index));
        }

        return BadRequest("Error occurred while deleting the user.");
    }
}