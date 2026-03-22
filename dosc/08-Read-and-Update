# Assignment 8: CRUD Operations - Read/Update a Record

## 1. Testing Instructions for Grading
To verify the "Read/Update" functionality and data persistence in the cloud, please use the following credentials:

* **Login Page:** [Click here to Login](https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Identity/Account/Login)
* **Test Username:** `professor@test.com`
* **Test Password:** `Assignment7!`

> **Note:** This account already contains workout records created in Assignment 7. These records can now be viewed and edited for this assignment.

---

## 2. Technical Implementation
This application features **Read and Update operations** that interact with the **Azure SQL Database** via **Entity Framework Core**.

### A. Read Operation (Workout Retrieval)
The application retrieves all workout records associated with the authenticated user.

* **View Records URL:** [https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Workouts/Index]

When the user navigates to this page, the system queries the `[dbo].[Workouts]` table and displays all records tied to the logged-in user's `UserId`.

---

### B. Update Operation (Workout Editing)
Users can edit previously created workout records through the Edit page.

* **Edit URL (Dynamic):**  
`https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Workouts/Edit/{id}`

> **Note:** The `{id}` is automatically generated based on the selected workout record.

---

### Process Flow (Read):
1. The user logs into the application.
2. The user navigates to the **Previous Workouts** page.
3. The `WorkoutsController` retrieves all records associated with the user's `UserId`.
4. The records are displayed in a table format with an **Edit** option for each entry.

---

### Process Flow (Update):
1. The user selects a workout and clicks **Edit**.
2. The application retrieves the selected record from the `[dbo].[Workouts]` table.
3. The form is pre-populated with the existing workout data.
4. The user modifies fields such as Activity Type, Exercise Name, Weight, Reps, etc.
5. The user submits the form.
6. The `WorkoutsController` captures the `POST` request and updates the record in the database.
7. The user is redirected back to the **Previous Workouts** page to verify the updated data.

---

## 3. Database Interaction

* **Database:** Azure SQL Database  
* **Table:** `[dbo].[Workouts]`  
* **ORM:** Entity Framework Core  

### Operations Performed:
* `SELECT` → Retrieve user-specific workout records  
* `UPDATE` → Modify existing workout entries  

---

## 4. Verification of Functionality

To confirm successful implementation:

1. Log in using the provided credentials  
2. Navigate to the Workouts Index page  
3. Select any existing workout  
4. Click **Edit**  
5. Modify a value (e.g., weight or reps)  
6. Save the changes  
7. Confirm the updated data appears in the list  

This demonstrates that records are both **retrievable (Read)** and **editable (Update)** within the application.
