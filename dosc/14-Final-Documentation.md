# TriFalcon Fitness – Final Project Documentation

## 1. Executive Summary & Project Overview
*   **Goals and Objectives:** TriFalcon Fitness is a web-based application built to allow athletes to track workout performance over time. The primary goal is to provide a central repository for Strength and Cardio data with easy-to-read historical logging.
*   **Key Stakeholders:** 
    *   **Primary Users:** Athletes and fitness enthusiasts.
    *   **Administrators:** System managers responsible for user oversight and data integrity.
    *   **Academic Evaluators:** Instructor assessing the implementation of ASP.NET Core MVC and Azure SQL.
*   **Business Value:** This software provides a high-speed, no-cost alternative to subscription-based fitness trackers, reducing the time required to log sets and reps by providing a streamlined, mobile-responsive UI.
*   **Critical Success Factors:** Persistent data storage in Azure SQL, successful implementation of Role-Based Access Control (RBAC), and passing all User Acceptance Testing (UAT).

---

## 2. System Architecture
*   **Client-side architecture:** Browser-based application utilizing HTML5, CSS3, and JavaScript.
*   **User interface specifications:** Built with the Bootswatch Cyborg theme for a high-contrast, "Dark Mode" fitness aesthetic.
*   **Supported browsers/devices:** Chrome, Edge, Firefox, and Safari (iOS/Android).
*   **Client-side technologies:** Bootstrap 5, FontAwesome 6, and jQuery for DOM manipulation.
*   **Server-side architecture:** 
    *   **Framework:** ASP.NET Core 10.0 MVC.
    *   **Database:** Azure SQL (Relational).
    *   **Authentication:** ASP.NET Core Identity (Hashed passwords, PBKDF2).
    *   **Hosting:** Microsoft Azure App Service.

---

## 3. Functional Requirements
### **User Stories / Use Cases**
*   **Actor:** Registered Athlete.
*   **Preconditions:** User must be authenticated.
*   **Flow of Events:** User selects "Log Activity" -> Inputs Exercise Name and Metrics -> Clicks Save -> System validates and redirects to "My Logs."
*   **Post conditions:** Data is permanently committed to the SQL database and associated with the User's ID.
*   **Exception Cases:** If mandatory fields (Exercise Name) are missing, the system provides immediate validation feedback.

### **Business Rules**
*   **Data Validation:** Weights must be positive numbers; Activity Types are limited to predefined categories (Strength, Cardio, etc.).
*   **Access Control:** Users cannot view, edit, or delete workout logs created by other users.
*   **Admin Rules:** Only users with the "Admin" role can access the user management dashboard.

---

## 4. Non-Functional Requirements
*   **Performance:** The system shall process CRUD operations and refresh views in under 2 seconds.
*   **Security:** 
    *   Data in transit is protected via HTTPS/TLS.
    *   Data at rest (passwords) is hashed; SQL Injection is prevented via EF Core Parameterized queries.
*   **Scalability:** The architecture supports scaling via Azure App Service Plan upgrades (Scale-up/Scale-out).
*   **Availability:** Target 99.9% uptime during standard usage hours.

---

## 5. Data Management
*   **Data Models:** Core entities include `ApplicationUser` (Identity) and `Workout` (Performance metrics).
*   **Relationships:** A "One-to-Many" relationship exists between Users and Workouts.
*   **Backup Strategy:** Automated backups are handled via Azure SQL’s Point-in-Time Restore (PITR).
*   **Privacy:** All data is stored in compliance with standard security practices, ensuring PII (Personally Identifiable Information) is limited to the email address used for login.

---

## 6. Infrastructure & Quality Assurance
*   **Environments:** 
    *   **Development:** Local IIS Express with SQL Express.
    *   **Production:** Azure Web App with Azure SQL.
*   **Testing Requirements:**
    *   **Unit Testing:** Performed via xUnit for model logic.
    *   **UI/UX Testing:** Evaluated through Cognitive Walkthroughs and Heuristic Evaluation (as documented in Assignment 12).
*   **Acceptance Criteria:** A "Success" is defined by a user being able to register, log a workout, see that workout in their history, and log out successfully.

---

## 7. Project Constraints and Assumptions
*   **Technical Constraints:** Limited by Azure Free Tier resources (F1 Service Plan).
*   **Assumptions:** It is assumed the user has a modern web browser and a stable internet connection for database synchronization.
*   **Dependencies:** Relies on Microsoft.EntityFrameworkCore and Microsoft.AspNetCore.Identity.UI packages.
