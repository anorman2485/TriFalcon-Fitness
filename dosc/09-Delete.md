# Assignment 9: CRUD Operations – Delete a Record  
**TriFalconFitness**

---

## 1. Testing Instructions for Grading

To verify the **Delete functionality** and data persistence in the Azure SQL database, please use the following credentials:

**Login Page:**  
https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Identity/Account/Login  

**Test Credentials:**  
- Username: professor@test.com  
- Password: Assignment7!  

**Data Note:**  
This account contains workout records created in previous assignments (Assignment 7 and 8). These records can now be deleted for testing purposes.

---

## 2. Deletion Strategy

### Chosen Approach: Hard Delete (Permanent Deletion)

The application implements a **hard delete strategy**, meaning records are permanently removed from the database when deleted.

### How It Works
- When a user deletes a workout, the record is **completely removed** from the database  
- The record **cannot be recovered** after deletion  
- Deleted records no longer appear in any queries or views  

### Reasoning
This approach was selected because:
- Simpler implementation for a small-scale application  
- No additional database fields or logic required  
- Provides immediate and clear feedback to users  
- Reduces system complexity for development and maintenance  

---

## 3. Technical Implementation

### Delete Operation Flow

1. User navigates to the **Workouts Index page**
2. User selects a workout record
3. User clicks the **Delete** button
4. Application prompts for confirmation
5. Upon confirmation:
   - The record is permanently deleted from the database
6. User is redirected back to the workouts list
7. The deleted record no longer appears

---

### Controller Logic (Hard Delete)

```csharp
[HttpPost]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var workout = await _context.Workouts.FindAsync(id);

    if (workout != null)
    {
        _context.Workouts.Remove(workout);
        await _context.SaveChangesAsync();
    }

    return RedirectToAction(nameof(Index));
}
