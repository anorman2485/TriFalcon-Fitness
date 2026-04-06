# TriFalcon Fitness – Assignment 10: Security Layer & Role-Based Access

---

## 1. Security Requirements & Plan
The primary security goal for **TriFalcon Fitness** is to protect sensitive personal health data and restrict administrative actions to authorized personnel only.

*   **Authentication:** Managed via **ASP.NET Core Identity** using secure, encrypted cookies.
*   **Authorization Strategy:** **Role-Based Access Control (RBAC)**.
*   **User Roles:** 
    *   **User:** Can perform CRUD operations strictly on their own personal workout data.
    *   **Admin:** Elevated "Superuser" access to the Admin Dashboard and System User Management.

---

## 2. Implementation Details
The security architecture is built using the **Microsoft Identity Membership Model**.

*   **Role Initialization:** Two roles (`Admin`, `User`) are programmatically initialized and managed via the `RoleManager` API.
*   **Controller Security:** The `AdminController` is protected by the `[Authorize(Roles = "Admin")]` attribute. This ensures that any unauthorized request to administrative routes is intercepted and blocked at the framework level.
*   **View-Level Security:** The global navigation (`_Layout.cshtml`) uses conditional rendering logic: `@if (User.IsInRole("Admin"))`. This hides or shows privileged navigation links based on the authenticated subject's permissions.

---

## 3. Role Management Interface
Role management is implemented using a combination of automated backend logic and a functional frontend dashboard.

*   **Automated Seeding:** I implemented an **Automated Seeding Interface** in `Program.cs`. This ensures that required security roles and the initial System Administrator account are created and validated upon application startup.
*   **Admin Dashboard:** Provides a secure interface for administrators to view all registered athletes and perform an **"Elevated Delete"** operation, which permanently removes a user and their associated data from the system.

---

## 4. Testing & Credentials

**Live Application URL:** [https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/](https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/)

| Access Level | Username | Password | Permissions |
| :--- | :--- | :--- | :--- |
| **Level 1 (Admin)** | `admin@trifalcon.com` | `Admin123!` | Access Admin Panel, Delete Users |
| **Level 2 (Professor)** | `professor@test.com` | `Assignment7!` | Standard Workout CRUD, No Admin Access |

---

