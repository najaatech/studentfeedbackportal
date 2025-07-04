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


