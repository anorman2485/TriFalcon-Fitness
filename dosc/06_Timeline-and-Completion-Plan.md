# Assignment 6 – Project Timeline & Completion Plan  
## TriFalconFitness  

---

# 1. Objective

This document provides a structured timeline and completion plan for the TriFalconFitness web-based fitness tracking system. It defines:

- What must be completed
- When it must be completed
- Who is responsible
- Dependencies between tasks
- Progress tracking
- Risks and mitigation strategies

This plan ensures completion of the required class elements:

1. **Technical Documentation**
2. **Complete System (Running Application + Testing)**
3. **End User Documentation**

---

# 2. Overall Project Timeline

| Phase | Start Date | End Date | Duration |
|-------|------------|----------|----------|
| Project Initiation | Jan 26 | Feb 2 | 1 Week |
| Documentation & Analysis | Feb 5 | Feb 12 | 1 Week |
| System Design | Feb 15 | Feb 23 | 1 Week |
| Development | Mar 2 | Apr 6 | 6 Weeks |
| Testing | Apr 7 | Apr 13 | 1 Week |
| User UI and UX | Apr 15 | Apr 20 | 1 Week |
| Documentation Finalization | Apr 23 | May 4 | 2 Weeks |
| Final Review & Submission | May 5 | May 11 | 1 Week |


---

# 3. Detailed Phase Breakdown

---

## Phase 1 – Project Initiation  
**January 26 – February 2**

| Task | Owner | Status | % Complete |
|------|--------|--------|------------|
| Define scope and goals | All | Complete | 100% |
| Assign team roles | All | Complete | 100% |
| GitHub repository setup | All | Complete | 100% |
| Azure environment setup | Alexis | Complete | 100% |

### Milestone:
✔ Development infrastructure operational

---

## Phase 2 – Documentation & Analysis  
**February 5 – February 12**

| Task | Owner | Status | % Complete |
|------|--------|--------|------------|
| Functional requirements documentation | Alexis | Complete | 100% |
| Non-functional requirements | All | Complete | 100% |
| Security requirements definition | All | Complete | 100% |
| Business rules documentation | All | Complete | 100% |

### Milestone:
✔ Requirements & Analysis Documentation Approved

---

## Phase 3 – System Design  
**February 15 – February 23**

| Task | Owner | Status | % Complete |
|------|--------|--------|------------|
| Database schema design | Tiyler | Complete | 100% |
| MVC architecture confirmation | Alexis | Complete | 100% |
| Security model documentation | Alexis | Complete | 100% |
| UI structural wireframes | Alexis | Complete | 100% |

### Milestone:
✔ Architecture & Database Design Finalized

---

## Phase 4 – Development  
**March 2 – April 6**

| Feature | Owner | Status | % Complete |
|----------|--------|--------|------------|
| Identity Authentication Setup | N/A | Pending | N/A |
| Workout Logging CRUD | N/A | Pending | N/A |
| Nutrition Logging CRUD | N/A | Pending | N/A |
| Wellness Metrics Tracking | N/A | Pending | N/A |
| Role-Based Access Controls | N/A | Pending | N/A |
| Backend Validation Logic | N/A | Pending | N/A |

### Dependencies:
- CRUD modules depend on finalized database schema
- User-specific logic depends on Identity configuration
- Validation depends on model completion

### Milestone:
✔ Core Backend Feature Freeze – April 6

---

## Phase 5 – Testing  
**April 7 – April 13**

| Task | Owner | Status | % Complete |
|------|--------|--------|------------|
| Manual functional testing | All | Pending | 0% |
| Authentication testing | All | Pending | 0% |
| Data validation testing | All | Pending | 0% |
| Azure deployment testing | All | Pending | 0% |
| Bug fix sprint | All | Pending | 0% |

### Dependencies:
- Requires backend feature freeze
- Requires near-final UI completion

### Milestone:
✔ Production-Ready Build – April 13

---

## Phase 6 – User UI and UX Enhancements  
**April 15 – April 20**

| Task | Owner | Status | % Complete |
|------|--------|--------|------------|
| Bootstrap styling improvements | All | In Progress | 60% |
| Responsive layout adjustments | All | In Progress | 70% |
| Navigation consistency review | All | Pending | 0% |
| Form usability improvements | All | Pending | 0% |
| Error message clarity updates | All | Pending | 0% |

### Milestone:
✔ Final UI/UX Completion – April 20

## Phase 7 – Documentation Finalization  
**April 23 – May 4**

### Technical Documentation (Required Element 1)

Includes:
- Full architecture overview
- Database schema diagrams
- Interface descriptions
- Security model explanation
- Azure deployment documentation
- Code structure documentation
- Maintenance instructions

| Owner | Status |
|--------|--------|
| N/A | In Progress |

---

### End User Documentation (Required Element 3)

Includes:
- Account registration guide
- Workout logging instructions
- Nutrition tracking instructions
- Wellness tracking guide
- Troubleshooting guide
- FAQ
- Screenshots from live Azure deployment

| Owner | Status |
|--------|--------|
| N/A | Pending |

---

## Complete System (Required Element 2)

The system will be considered complete when:

- Azure deployment is stable
- All CRUD features operate correctly
- Authentication and authorization function properly
- HTTPS encryption verified
- Database migrations finalized
- Testing phase completed successfully

Target Completion: April 13

---

# 4. Task Dependencies Overview

| Task | Depends On |
|------|------------|
| Development | System Design |
| UI Improvements | Backend completion |
| Testing | Development freeze |
| Final Screenshots | Production deployment |
| Documentation | Finalized system |

---

# 5. Resource Allocation

## Team Roles

- **Don Tran**
  - Authentication & Security Model
  - Repository Management
  - Technical Documentation

- **Tiyler Miller**
  - Azure Deployment
  - Database Management
  - UI Styling & Infrastructure

- **Alexis Norman**
  - Feature Development
  - End User Documentation
  - Form & UX Improvements

## Technical Resources

- Visual Studio
- .NET 10 SDK
- Azure App Service (F1 Tier)
- Azure SQL Database
- GitHub

---

# 6. Cost Estimation

| Resource | Estimated Cost |
|----------|----------------|
| Azure Hosting (F1 Tier) | $0 |
| Azure SQL | $0 |
| Development Tools | $0 |

**Total Estimated Cost: $0**

---

# 7. Risk Assessment & Mitigation

| Risk | Impact | Mitigation |
|------|--------|------------|
| Azure Free Tier performance limits | Slow response times | Optimize database queries |
| Authentication misconfiguration | Security vulnerability | Dedicated testing phase |
| Team scheduling conflicts | Delays | Weekly progress meetings |
| Database migration errors | Downtime | Backup before migrations |
| Scope creep | Missed deadline | Feature freeze April 6 |

---

# 8. Progress Tracking Strategy

Progress will be tracked through:

- GitHub Issues
- Pull Requests
- Weekly milestone reviews
- % completion updates
- Planned vs Actual schedule comparison

If progress falls behind:
1. Reallocate tasks
2. Reduce non-essential UI improvements
3. Prioritize stability over new features

---

# 9. Definition of Completion

The project is complete when:

- The Azure-hosted application runs without critical errors
- Core workout, nutrition, and wellness features function correctly
- Secure authentication is verified
- Technical documentation is finalized
- End-user documentation is finalized
- Repository is organized and tagged for final submission
- Submission occurs between May 5 – May 11, 2026

---

# Final Statement

This structured timeline ensures TriFalconFitness meets all academic requirements, aligns with its Azure deployment architecture, and remains on schedule for final submission in May 2026.

The combination of defined milestones, task ownership, dependency mapping, and risk management provides a realistic and achievable completion strategy.
