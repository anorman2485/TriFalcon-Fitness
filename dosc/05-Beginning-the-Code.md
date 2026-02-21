# Assignment 5: Beginning the Code Documentation - TriFalcon_Fitness

**Live Application URL:**  
https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/

---

## 1. Purpose and Overview of Application

The TriFalcon Fitness application is a web-based fitness tracking platform designed to allow users to log workouts, monitor progress, and manage personal fitness goals through an intuitive interface. This documentation outlines the system architecture, development environment, and setup procedures so any developer can clone, configure, and continue development without additional guidance.

---

## 2. Stack Elements and System Architecture

### **Technology Stack**
* **Frontend:** ASP.NET Core MVC Razor Views  
* **Backend:** ASP.NET Core using C#  
* **Database:** SQL Server LocalDB  
* **ORM / Connector:** Entity Framework Core  
* **Runtime Framework:** .NET  
* **Version Control:** GitHub  
* **Development Environment:** Visual Studio  

### **System Interaction Flow**

| Step | Process |
| :--- | :--- |
| **1** | User sends request through browser |
| **2** | MVC Controller processes request |
| **3** | Models handle business logic |
| **4** | Entity Framework communicates with database |
| **5** | SQL Server returns data |
| **6** | Razor View renders response |

Entity Framework Core serves as the bridge between application logic and the database, automatically mapping models to relational tables.

---

## 3. Language and Coding Standards

### **Primary Language**
* C# within the ASP.NET Core MVC framework  

### **Coding Conventions**
* PascalCase for classes and methods  
* camelCase for variables and parameters  
* Descriptive naming for controllers and models  
* Separation of concerns through MVC architecture  
* Consistent folder and file organization  

The project follows object-oriented principles and standard MVC routing patterns to maintain maintainability and scalability.

---

## 4. Interface Integration Overview

The user interface is implemented using Razor Views and shared layouts to ensure consistent navigation and styling across pages. Interface components designed in previous assignments integrate directly with backend logic through MVC controller actions and model binding.

Navigation remains persistent across views, allowing users to move between features seamlessly while maintaining application state.

---

## 5. Code Modules and Application Structure

### **Directory Structure Overview**

| Module | Purpose |
| :--- | :--- |
| **Controllers** | Handle HTTP requests and application logic |
| **Models** | Represent database entities and rules |
| **Views** | Render UI using Razor templates |
| **Data** | Contains database context and migrations |
| **wwwroot** | Stores static assets (CSS, JS, images) |
| **appsettings.json** | Stores configuration settings |
| **Program.cs** | Configures application startup |

### **Application Flow**
User Interaction → Controller → Model → Database → View Response  

This modular structure supports scalability and simplifies feature development.

---

## 6. Platform and Hosting Environment

### **Local Development Requirements**
* Visual Studio with ASP.NET workload  
* .NET SDK  
* SQL Server LocalDB  
* Git  

### **Local Setup Process**
1. Clone repository from GitHub  
2. Open solution in Visual Studio  
3. Verify connection string in appsettings.json  
4. Open Package Manager Console  
5. Run `Update-Database`  
6. Build and run the application  

### **Cloud Deployment**
The application is hosted on Azure App Service, allowing remote access for testing while maintaining a local development workflow.

---

## 7. Development Workflow and Continuity

Version control is managed through GitHub using a branching workflow.

* Developers create feature branches  
* Changes are committed locally  
* Pull requests are submitted for review  
* Code is merged after approval  

This workflow ensures collaboration, version tracking, and code stability.

---

## 8. System Readiness Summary

The TriFalcon Fitness application successfully builds and runs within the configured development environment. Database connectivity has been verified through Entity Framework migrations, confirming the schema is up to date. The architecture supports continued feature development and collaborative workflows.

---
