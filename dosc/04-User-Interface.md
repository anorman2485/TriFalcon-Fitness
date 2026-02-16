# Assignment 4: User Interface Design Documentation - TriFalcon_Fitness

**Live Application URL:** [https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/](https://trifalconfitness-bebpfncjd6gda0eu.canadacentral-01.azurewebsites.net/)

---

## 1. Use Case Scenarios
* **Scenario A (New User Onboarding):** A potential member visits the site and is greeted by the public "Hero" section. The user identifies the "Join Now" call-to-action to initiate the registration process.
* **Scenario B (Daily Activity Logging):** An existing user logs in to record a completed training session. From the personalized dashboard, they click "Start Logging." The interface provides a streamlined form where they can input specific sets, reps, and miles, ensuring data is captured quickly.
* **Scenario C (Long-term Progress Review):** After weeks of logging, the user wants to see if they are hitting their targets. They navigate to the "Progress" link in the navbar to see a visual comparison of their logged data against the goals set in their profile.

---

## 2. In-Depth Task Analysis
**Goal: Log a Fitness Activity and Verify Progression**

| Phase | User Action & System Response |
| :--- | :--- |
| **1. Entry** | User enters credentials; System validates against the Identity database and redirects to the personalized Member Dashboard. |
| **2. Navigation** | User scans the 3-column grid; identifies the "Log Workout" card via the visual icon and "Start Logging" button. |
| **3. Configuration** | User interacts with the form; selects the activity type (Running, Weightlifting, etc.) to reveal relevant input fields. |
| **4. Input** | User enters raw metrics: Distance/Time for cardio or Exercise/Sets/Reps for strength. The UI uses HTML5 "number" types to ensure mobile keyboards default to the numeric pad. |
| **5. Validation** | User clicks "Save Workout."  |
| **6. Feedback** | The system redirects the user to the Progress page where the newly entered data is immediately reflected in the performance charts. |

---

## 3. UI Design Specifications
* **Theme: Bootswatch Cyborg.** 
* **Color Palette:**
    * **Background:** Deep Black (`#060606`) 
    * **Interactive Accents:** Cyan Blue (`#2a9fd6`) and Info Blue (`#31b0d5`) for primary buttons.
    * **Success Indicators:** Green (`#77b300`) for goal completion and PR notifications.
* **UI Components:**
    * **The Hero Section:** Featured on the landing page with bold typography and a clear CTA (Call to Action) for conversion.
    * **Card-Based Dashboard:** A responsive 3-column layout that categorizes tasks into Log, Progress, and Settings.
    * **Adaptive Charting:** Built with Chart.js to provide visual feedback of user performance over time.

---

## 4. Cognitive Walkthrough & Heuristic Evaluation

### Visibility of System Status
The dashboard uses a "Welcome back, [Username]" header, ensuring the user is immediately aware of their authentication state. Progress bars on the Analytics page show exactly how much of a goal has been completed, leaving no ambiguity about progress.

### Match Between System and Real World
The application avoids technical database jargon, using athlete-centric terms like "Sets," "Reps," and "Miles." This follows the user's existing mental model of a physical workout log.

### Consistency and Standards
The navigation bar is persistent across all views. Navigation follows standard MVC routing patterns, providing a predictable and stable user journey that matches modern web standards.

### Recognition Rather Than Recall
By providing distinct, high-contrast cards for different tasks on the home screen, the user doesn't have to remember where features are located. Action buttons are presented clearly on the primary dashboard.

### Aesthetic and Minimalist Design
The Cyborg theme removes unnecessary decorations. This minimalist approach ensures that on the "Progress" page, the data is the focal point of the screen.

### Help and Documentation
Form inputs utilize clear placeholder text (e.g., "e.g. 5k Run") to guide user input, showing the expected format at the exact moment it is required.

---

## 5. Screen Documentation & Data Entry Shortcuts
* Screenshots of all pages are listed in the images folder.*

### **Screen 1: Public Landing Page**
* **Purpose:** Initial user conversion and branding.
* **Elements:** Hero image, site mission statement, "Join Now" and "Member Login" buttons.

### **Screen 2: Member Dashboard (Home)**
* **Purpose:** Central navigation and user orientation.
* **Elements:** Personalized greeting, Activity Card, Progress Card, and Settings Card.

### **Screen 3: Log Activity (Data Entry)**
* **Purpose:** High-frequency data entry.
* **Input Types:** Dropdown (Activity Type), Number (Weight, Sets, Reps), Text (Exercise Name).

### **Screen 4: Performance Analytics (Progress)**
* **Purpose:** High-level data visualization.
* **Elements:** Line charts (Actual vs. Goal) and milestone completion lists.

### **Screen 5: User Settings & Profile**
* **Purpose:** Management of account identity and physical biometrics.
* **Input Types:** Text (Name), Email, Number (Weight, Height, Goal Weight).
