# Student Feedback Portal
This is a Student Feedback Portal project that allows authenticated users (students) to submit anonymous feedback on courses and instructors. Admins (staff) should be able to view and analyze the collected feedback.

# Requirements
## Student Features
- Login (Simulated) with hardcoded user and role (Student)
- View a list of enrolled courses
- Submit anonymous feedback: Rating (1–5) / Text comment
- Cannot submit more than one feedback per course

# Admin Features (Staff)
- Login (Simulated) with hardcoded user and role (Admin)
- View feedback reports:
    - Course-wise aggregation
    - Instructor-wise aggregation
- Search/filter by course or instructor
- Optional: Export to Excel


# Note regarding AI
You may use AI-based coding assistants (e.g., GitHub Copilot, ChatGPT) to support your development. However, you are expected to write, understand, and explain all code you submit. Copy-pasted solutions that you cannot justify will result in disqualification.

# Getting Started

## Visual Studio Code Extensions / Libraries
- C# Dev Kit
- https://dotnet.microsoft.com/en-us/download/dotnet/9.0


# Backend setup commands
dotnet tool install --global dotnet-ef --version 9.0.6
cd backend/StudentFeedback.API  
dotnet dev-certs https --trust  
dotnet restore  
dotnet run --launch-profile https  


# Frontend setup commands
cd frontend/student-feedback-frontend-app  
npm install  
npm run dev  

## frontend url
http://localhost:3000

## swagger url
https://localhost:7222/swagger

# Database script
Copy and paste the content of init.sql into SQL Management Studio


# Developer Assessment Skills Evaluation

## Backend Skills (.NET/C#)

### Core Technologies
- **ASP.NET Core Web API** - Building modern RESTful APIs
- **Entity Framework Core** - Object-Relational Mapping and database operations
- **SQL Server** - Database design, management, and optimization
- **C# Programming** - Modern language features and best practices

### Architecture & Patterns
- **RESTful API Design** - Proper HTTP methods, status codes, and resource modeling
- **Dependency Injection** - IoC container usage and service registration
- **Repository Pattern** - Data access abstraction and testability
- **Service Layer Pattern** - Business logic separation
- **Clean Architecture** - Separation of concerns and maintainable code structure

### Advanced Features
- **Authentication/Authorization** - JWT token implementation and security
- **CORS Configuration** - Cross-origin resource sharing setup
- **API Documentation** - Swagger/OpenAPI integration
- **Data Validation** - Input validation and error handling
- **Database Migrations** - Schema evolution and version control

## Frontend Skills (React/Next.js)

### Core Technologies
- **Next.js 14+** - Modern React framework with App Router
- **React** - Component-based UI development
- **JavaScript/TypeScript** - Modern ES6+ features and type safety
- **CSS Modules** - Scoped styling and maintainable CSS

### React Concepts
- **React Hooks** - useState, useEffect, and custom hooks
- **Client-side State Management** - Component state and data flow
- **Event Handling** - User interactions and form submissions
- **Conditional Rendering** - Dynamic UI based on application state

### Frontend Architecture
- **Component-based Architecture** - Reusable and maintainable UI components
- **API Integration** - HTTP client implementation and async operations
- **Error Handling** - User-friendly error states and validation
- **Responsive Design** - Mobile-first and cross-device compatibility

## Database Skills

### Database Design
- **Relational Database Design** - Proper table structure and normalization
- **Entity Relationships** - One-to-Many, Many-to-Many associations
- **Primary and Foreign Keys** - Data integrity and referential constraints
- **Indexing Strategy** - Performance optimization

### Data Management
- **Entity Framework Migrations** - Database version control
- **Seed Data Implementation** - Initial data setup and testing
- **Query Optimization** - Efficient data retrieval patterns
- **Data Modeling** - Domain entities and business logic representation

## DevOps & Tooling Skills

### Version Control
- **Git** - Source code management and collaboration
- **Repository Management** - Branching strategies and code organization
- **Gitignore Configuration** - Proper file exclusion patterns

### Containerization
- **Docker** - Application containerization and deployment
- **Container Configuration** - Multi-stage builds and optimization

### Package Management
- **NuGet** - .NET package management and dependencies
- **npm** - Node.js package management and build tools
- **Environment Configuration** - Development vs production settings

## Problem-Solving Areas Tested

### 1. Database Design Challenges
- Creating normalized database schemas
- Implementing complex entity relationships
- Handling data constraints and validation rules
- Optimizing query performance

### 2. API Development Tasks
- CRUD operations implementation
- RESTful endpoint design
- Error handling and status codes
- Authentication and authorization flows

### 3. Frontend Integration Challenges
- Consuming RESTful APIs
- Managing asynchronous operations
- State management across components
- User experience and interface design

### 4. Security Implementation
- JWT token generation and validation
- Secure API endpoints
- Input sanitization and validation
- CORS policy configuration

### 5. Error Handling & Validation
- Server-side input validation
- Client-side form validation
- Graceful error recovery
- User feedback and messaging

## Skill Level Assessment

### Junior Developer (1-2 years)
- Basic CRUD operations
- Simple React components
- Database table creation
- API endpoint consumption
- Basic styling and layout

### Mid-Level Developer (2-5 years)
- Complex entity relationships
- Authentication implementation
- Advanced React patterns
- Error handling strategies
- Performance considerations

### Senior Developer (5+ years)
- Architecture decision making
- Security best practices
- Code organization and patterns
- Performance optimization
- Scalability considerations
- Code review and mentoring capabilities

## Technology Stack Summary

**Backend:**
- .NET 8 / ASP.NET Core
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger/OpenAPI

**Frontend:**
- Next.js 14+ (App Router)
- React 18+
- CSS Modules
- Modern JavaScript/ES6+

**DevOps:**
- Docker containerization
- Git version control
- Package managers (NuGet, npm)

**Testing Areas:**
- Unit testing capabilities
- Integration testing
- API testing
- Frontend component testing