-- Make sure StudentFeedbackDB is created before running this script.

-- Drop existing tables if they exist
DROP TABLE IF EXISTS Feedback;
DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Instructors;

-- ======================
-- Tables
-- ======================

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Instructors (
    Id INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Department NVARCHAR(100) NOT NULL
);

CREATE TABLE Courses (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    InstructorId INT NOT NULL,
    FOREIGN KEY (InstructorId) REFERENCES Instructors(Id)
);

CREATE TABLE Enrollments (
    Id INT PRIMARY KEY IDENTITY,
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    CONSTRAINT UQ_Enrollment UNIQUE (StudentId, CourseId)
);

CREATE TABLE Feedback (
    Id INT PRIMARY KEY IDENTITY,
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),
    Comment NVARCHAR(MAX),
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    CONSTRAINT UQ_Feedback UNIQUE (StudentId, CourseId)
);

-- ======================
-- Sample Seed Data
-- ======================

-- Instructors
INSERT INTO Instructors (FullName, Department) VALUES 
('Dr. Sarah Al-Rashed', 'Computer Science'),
('Prof. Ahmed Al-Fulan', 'Information Systems');

-- Courses
INSERT INTO Courses (Name, InstructorId) VALUES 
('Intro to Programming', 1),
('Database Design', 2);

-- Students
INSERT INTO Students (FullName, Email) VALUES 
('Aisha Al-Harbi', 'aisha@ktu.edu.kw'),
('Fahad Al-Mutairi', 'fahad@ktu.edu.kw');

-- Enrollments
INSERT INTO Enrollments (StudentId, CourseId) VALUES 
(1, 1),
(1, 2),
(2, 2);

-- Feedback (ignore for now, add through APIs)
-- INSERT INTO Feedback (StudentId, CourseId, Rating, Comment) VALUES 
-- (1, 1, 4, 'Great intro course!'),
-- (1, 2, 5, 'Very detailed and helpful.'),
-- (2, 2, 3, 'Could use more practical examples.');