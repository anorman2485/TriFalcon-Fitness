# TriFalcon Fitness – Assignment 9: Delete Operation

## Overview
This project implements the **Delete functionality** for workout records in the TriFalcon Fitness web application. The application uses **ASP.NET Core MVC** with **Entity Framework** and **Identity** for user authentication.

- **Deletion Strategy:** Hard Delete (records are permanently removed)
- **User-Specific:** Only the logged-in user can delete their own workouts
- **Database:** Azure SQL Database

---

## Testing Instructions
**Login Page:**  
[TriFalcon Fitness Login](https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Identity/Account/Login)

**Test Credentials:**
- **Username:** professor@test.com  
- **Password:** Assignment7!  

> The test account contains workouts from previous assignments. Use these to verify deletion.

---

## Deletion Flow

1. Log in to the application  
2. Navigate to the **Workouts Index** page  
3. Only workouts belonging to the logged-in user are listed  
4. Click the **Delete** button on a workout  
5. Confirm deletion on the confirmation page  
6. The workout is **permanently deleted** and no longer appears in the list  

---

## Controller Implementation

```csharp
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var user = await _userManager.GetUserAsync(User);
    if (user == null) return Challenge();

    var workout = await _context.Workouts
        .FirstOrDefaultAsync(w => w.Id == id && w.UserId == user.Id);

    if (workout == null)
    {
        return NotFound();
    }

    _context.Workouts.Remove(workout);
    await _context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));
}
