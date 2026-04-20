# TriFalcon Fitness – Assignment 12: UI/UX Evaluation & User Acceptance

## 1. Objective
The goal of this evaluation was to ensure that the TriFalconFitness application is easy to use and intuitive for end users. Multiple UI/UX evaluation methods that can be used could include cognitive walkthrough, heuristic evaluation, Survey Techniques, End User Observation, etc.

## 2. Evaluation Methods
The following methods were utilized to ensure the appropriate UI/UX standards were met:
* **Cognitive Walkthrough:** A task-based simulation to identify friction in the user journey.
* **Heuristic Evaluation:** A system audit against industry-standard usability principles.

---

## 3. Cognitive Walkthrough
A cognitive walkthrough was performed by simulating a first-time user completing key tasks within the application.

### **Task 1: Homepage → Login/Register**
* **Steps:**
  1. User lands on the homepage.
  2. User reads application title and description.
  3. User selects either “Join Now” or “Login.”
* **Findings:**
  * The purpose of the application is clear.
  * “Join Now” button is visually prominent.
  * Navigation bar includes multiple options (Dashboard, My Logs, Log Activity, Progress).
* **Issues Identified:**
  * “Login” button is less noticeable than “Join Now.”
  * Navigation options may confuse unauthenticated users.
  * No explanation of navigation items.
* **Improvements:**
  * Increase visibility of the “Login” button.
  * Hide or restrict navigation options before login to prevent "dead-end" clicks.
  * Add a section where we go in depth on how to use TriFalcon-Fitness as a whole.

### **Task 2: Logging a Workout**
* **Steps:**
  1. User navigates to “Log Activity.”
  2. User views the “Log Your Workout” form.
  3. User fills out fields (activity type, exercise name, weight, sets, reps, distance, duration).
  4. User clicks “Save Workout.”
* **Findings:**
  * Form layout is clean and well-organized.
  * Labels and placeholders are helpful.
  * Workflow is easy to follow.
* **Issues Identified:**
  * Required fields are not clearly indicated.
  * Units (lbs, mi, min) are not highly visible.
  * No confirmation message after saving.
* **Improvements:**
  * Add required field indicators (*) to the UI.
  * Improve visibility of measurement units.
  * Implement front-end validation to prevent incomplete submissions.

---

## 4. Heuristic Evaluation
The site was audited against **Nielsen’s Usability Heuristics** to ensure a professional and safe user experience.

* **Visibility of System Status:** We identified that users need immediate feedback. While the database updates correctly, we implemented UI logic to ensure navigation links only appear when relevant to the user's status (logged in vs. logged out).
* **Consistency and Standards:** The application maintains a consistent visual language using the **Bootswatch Cyborg** theme. All destructive actions (Delete) are consistently styled with red outlines to signify high-risk operations.
* **Error Prevention:** To prevent accidental data loss, we implemented a **JavaScript Confirmation Dialog** on the Admin and Workout delete buttons. This ensures the user is certain of their intent before a permanent deletion occurs.

---

## 5. Summary of Implemented UI/UX Changes
Following the evaluation, the following "dynamic changes" were made to the TriFalcon Fitness design:

1.  **Navigation Guarding:** Links to "Log Activity," "My Logs," and "Progress" are now programmatically hidden from unauthenticated users in the `_Layout.cshtml`. This ensures a cleaner interface for new visitors.
2.  **Form Hardening:** Added HTML5 `required` attributes and visual asterisks (*) to the Workout Creation form. This provides immediate browser-level feedback if a user misses a required field.
3.  **Safety Interlocks:** Added `onsubmit` confirmation pop-ups to all delete forms to fulfill the "Error Prevention" heuristic.
4.  **Role-Specific Badging:** Added distinct badges (e.g., "System Administrator Access") to privileged dashboards to provide clear system status to high-level users.

## 6. Conclusion
By combining the **Cognitive Walkthrough** with a **Heuristic Evaluation**, we moved beyond a simple functional prototype to a user-accepted platform. These evaluations directly resulted in a more secure, intuitive, and streamlined experience for the end-user.
