# Student Feedback Portal

This is a Student Feedback Portal project that allows authenticated users (students) to submit anonymous feedback on courses and instructors. Admins (staff) should be able to view and analyze the collected feedback.

## Technology Stack Summary

### Backend
- .NET 9 / ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI

### Frontend
- Next.js 15 (App Router)
- React 19
- CSS Modules
- Modern JavaScript/ES6+

### DevOps
- Git version control
- Package managers (NuGet, npm)

## Assessment Requirements

### Student Features
- Login (Simulated) with hardcoded user and role (Student)
- View a list of enrolled courses
- Submit anonymous feedback:
  - Rating (1–5)
  - Text comment
- Cannot submit more than one feedback per course

### Admin Features (Staff)
- Login (Simulated) with hardcoded user and role (Admin)
- View feedback reports:
  - Course-wise aggregation
  - Instructor-wise aggregation
- Search/filter by course or instructor
- Optional: Export to Excel

## Getting Started

### Prerequisites
- [.NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Visual Studio Code with C# Dev Kit extension
- SQL Server

### Installation

#### Backend Setup
```bash
# Install Entity Framework tools
dotnet tool install --global dotnet-ef --version 9.0.6

# Navigate to backend directory
cd backend/StudentFeedback.API

# Trust development certificates
dotnet dev-certs https --trust

# Restore packages
dotnet restore

# Run the API
dotnet run --launch-profile https
```

#### Frontend Setup
```bash
# Navigate to frontend directory
cd frontend/StudentFeedback.APP

# Install dependencies
npm install

# Run development server
npm run dev
```

#### Database Setup
1. Copy and paste the content of `init.sql` into SQL Server Management Studio
2. Execute the script to create the database and seed data

### URLs
- **Frontend**: http://localhost:3000
- **Backend API**: https://localhost:7222/swagger

## Note Regarding AI

You may use AI-based coding assistants (e.g., GitHub Copilot, ChatGPT) to support your development. However, you are expected to write, understand, and explain all code you submit. Copy-pasted solutions that you cannot justify will result in disqualification.

---

## Developer Assessment Skills Evaluation

This project evaluates a comprehensive range of full-stack development skills across different experience levels.

### Backend Skills (.NET/C#)

#### Core Technologies
- **ASP.NET Core Web API** - Building modern RESTful APIs
- **Entity Framework Core** - Object-Relational Mapping and database operations
- **SQL Server** - Database design, management, and optimization
- **C# Programming** - Modern language features and best practices

#### Architecture & Patterns
- **RESTful API Design** - Proper HTTP methods, status codes, and resource modeling
- **Dependency Injection** - IoC container usage and service registration
- **Repository Pattern** - Data access abstraction and testability
- **Service Layer Pattern** - Business logic separation
- **Clean Architecture** - Separation of concerns and maintainable code structure

#### Advanced Features
- **Authentication/Authorization** - JWT token implementation and security
- **CORS Configuration** - Cross-origin resource sharing setup
- **API Documentation** - Swagger/OpenAPI integration
- **Data Validation** - Input validation and error handling
- **Database Migrations** - Schema evolution and version control

### Frontend Skills (React/Next.js)

#### Core Technologies
- **Next.js 15** - Modern React framework with App Router
- **React 19** - Component-based UI development
- **JavaScript/TypeScript** - Modern ES6+ features and type safety
- **CSS Modules** - Scoped styling and maintainable CSS

#### React Concepts
- **React Hooks** - useState, useEffect, and custom hooks
- **Client-side State Management** - Component state and data flow
- **Event Handling** - User interactions and form submissions
- **Conditional Rendering** - Dynamic UI based on application state

#### Frontend Architecture
- **Component-based Architecture** - Reusable and maintainable UI components
- **API Integration** - HTTP client implementation and async operations
- **Error Handling** - User-friendly error states and validation
- **Responsive Design** - Mobile-first and cross-device compatibility

### Database Skills

#### Database Design
- **Relational Database Design** - Proper table structure and normalization
- **Entity Relationships** - One-to-Many, Many-to-Many associations
- **Primary and Foreign Keys** - Data integrity and referential constraints
- **Indexing Strategy** - Performance optimization

#### Data Management
- **Entity Framework Migrations** - Database version control
- **Seed Data Implementation** - Initial data setup and testing
- **Data Modeling** - Domain entities and business logic representation

### DevOps & Tooling Skills

#### Version Control
- **Git** - Source code management and collaboration

#### Package Management
- **NuGet** - .NET package management and dependencies
- **npm** - Node.js package management and build tools
- **Environment Configuration** - Development vs production settings

### Problem-Solving Areas Tested

#### 1. Database Design Challenges
- Handling data constraints and validation rules

#### 2. API Development Tasks
- CRUD operations implementation
- RESTful endpoint design
- Error handling and status codes
- Authentication and authorization flows

#### 3. Frontend Integration Challenges
- Consuming RESTful APIs
- Managing asynchronous operations
- State management across components
- User experience and interface design

#### 4. Security Implementation
- Secure API endpoints with headers
- Input sanitization and validation
- CORS policy configuration

#### 5. Error Handling & Validation
- Server-side input validation
- Client-side form validation
- Graceful error recovery
- User feedback and messaging
