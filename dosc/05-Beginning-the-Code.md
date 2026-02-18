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


