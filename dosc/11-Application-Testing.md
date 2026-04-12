# TriFalconFitness – Software Test Plan

## 1. Objective
This document defines the testing strategy for the TriFalconFitness web application. It includes a combination of **unit testing (automated)** and **end-user testing (manual)** to verify that core features function correctly and provide a reliable user experience.

---

## 2. Scope of Testing
Testing will focus on key system components:

- User Authentication (Register/Login)
- Workout CRUD Operations (Create, Read, Update, Delete)
- Data Validation
- Role-Based Access Control
- UI Navigation and User Experience

Testing is limited to **Unit Testing and Integration Testing** and is not intended to be fully comprehensive.

---

## 3. Testing Approach

### Automated Testing (Unit Testing)
- Focuses on backend logic (controllers, validation, data handling)
- Tests individual functions and components in isolation
- Tools (planned):
  - **xUnit** (for .NET unit testing)
  - Optional: **Selenium** (for UI automation)

### Manual Testing (End User Testing)
- Simulates real user behavior
- Verifies UI usability and workflow
- Ensures system behaves correctly under normal and edge cases

---

## 4. Test Environment

| Component   | Description                              |
|------------|------------------------------------------|
| Development| Visual Studio, .NET 10                   |
| Database   | Azure SQL Database                       |
| Hosting    | Azure App Service (F1 Tier)              |
| Browser    | Chrome, Edge, Firefox                    |
| Test Accounts | professor@test.com (provided)        |

---

## 5. Test Case Format

Each test case includes:

- **Test Case ID**
- **Test Description**
- **Test Type** (Automated / Manual)
- **Input**
- **Expected Output**
- **Pass/Fail Criteria**

---

## 6. Sample Test Cases

###  Authentication Testing

**Test Case ID:** AUTH-01  
**Description:** User logs in with valid credentials  
**Type:** Manual  

**Input:**
- Username: professor@test.com  
- Password: Assignment7!  

**Expected Output:**
- User is redirected to dashboard  

**Pass Criteria:**
- Login successful and dashboard loads  

---

**Test Case ID:** AUTH-02  
**Description:** Reject invalid password  
**Type:** Automated  

**Input:**
- Valid email  
- Incorrect password  

**Expected Output:**
- Error message displayed  

**Pass Criteria:**
- Login fails and error message appears  

---

###  Workout Creation Testing

**Test Case ID:** CRUD-01  
**Description:** Create a new workout  
**Type:** Manual  

**Input:**
- Activity: Running  
- Distance: 5 miles  

**Expected Output:**
- Workout saved and appears in list  

**Pass Criteria:**
- Data persists in database and displays correctly  

---

**Test Case ID:** CRUD-02  
**Description:** Reject empty required fields  
**Type:** Automated  

**Input:**
- Missing Activity Name  

**Expected Output:**
- Validation error triggered  

**Pass Criteria:**
- Form submission blocked with error message  

---

###  Workout Update Testing

**Test Case ID:** CRUD-03  
**Description:** Update existing workout  
**Type:** Manual  

**Input:**
- Modify weight or reps  

**Expected Output:**
- Updated values saved  

**Pass Criteria:**
- Changes reflected in workout list  

---

###  Workout Deletion Testing

**Test Case ID:** CRUD-04  
**Description:** Delete a workout  
**Type:** Manual  

**Input:**
- Select workout → Delete  

**Expected Output:**
- Workout removed from database  

**Pass Criteria:**
- Record no longer appears in list  

---

###  Authorization Testing

**Test Case ID:** SEC-01  
**Description:** Prevent access to another user’s data  
**Type:** Automated  

**Input:**
- User attempts to access another user's workout  

**Expected Output:**
- Access denied or not found  

**Pass Criteria:**
- Data is not accessible  

---

## 7. Integration Testing

Integration testing ensures that components work together correctly:

- Controller → Model → Database flow  
- Authentication → Authorization → Data access  
- UI forms → Backend validation → Database updates  

---

## 8. Selenium (Optional Automation)

Selenium may be used to automate UI-based test cases such as:

- Logging in  
- Navigating pages  
- Submitting forms  

**Limitations:**
- Requires setup and scripting  
- May not be necessary for small-scale projects  

---

## 9. Pass/Fail Criteria

- **PASS:** Actual result matches expected output  
- **FAIL:** System behaves incorrectly or produces errors  

---

## 10. Testing Completion Criteria

Testing is complete when:

- Core features (Authentication, CRUD) function without errors  
- No critical bugs remain  
- Application runs successfully on Azure  
- Both automated and manual tests have been executed  

---

## 11. Summary

This test plan ensures that TriFalconFitness is:

- Functionally correct  
- Secure  
- User-friendly  

By combining **automated unit testing** with **manual testing**, the system is validated from both a technical and user perspective.
