# Assignment 7: CRUD Operations - Create a Record

## 1. Testing Instructions for Grading
To verify the "Create" functionality and data persistence in the cloud, please use the following credentials:

* **Login Page:** [Click here to Login](https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Identity/Account/Login)
* **Test Username:** `professor@test.com`
* **Test Password:** `Assignment7!`

> **Note:** I have already pre-registered this account on the live Azure SQL database. You may also use the **Register** page to create a unique user or use the link below to create a workout record under the test account.

---

## 2. Technical Implementation
This application features two primary "Create" operations that interact with the **Azure SQL Database** via **Entity Framework Core**.

### A. User Account Creation (Identity)
When a user registers, the `UserManager<ApplicationUser>` service validates the input and generates an `INSERT` command into the `[dbo].[AspNetUsers]` table.

### B. Workout Record Creation (Custom Domain Data)
The core of the application allows authenticated users to log specific fitness activities.
* **Create URL:** [https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Workouts/Create]
* **Retrievable At:** [https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/Workouts/Index]



### Process Flow:
1. The user inputs workout data (Activity Type, Exercise Name, Weight, Reps, etc.).
2. The `WorkoutsController` captures the `POST` request and programmatically assigns the `UserId` of the logged-in user.
3. The record is saved to the `[dbo].[Workouts]` table.
4. The user is redirected to the **Previous Workouts** index to verify the record was successfully stored and is immediately retrievable.

