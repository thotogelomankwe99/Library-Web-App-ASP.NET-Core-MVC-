# Library-Web-App(ASP.NET Core MVC)

# Library Management System

  A web-based Library Management System built using ASP.NET Core MVC and C#, designed to demonstrate core Object-Oriented Programming principles and structured MVC architecture.

#  Project Overview

## The Library Management System allows users to:

  Add new books

  View available books

  Borrow books

  Return books

  Track book availability status

## This project focuses on applying clean architecture principles and separating business logic from presentation logic using the MVC pattern.

# Technologies Used

  C#

  ASP.NET Core MVC

  Razor Views

  HTML5

  CSS3

  .NET SDK

# Architecture

## The application follows the Model-View-Controller (MVC) design pattern:

🔹 Models

  Book.cs – Represents a book entity.

  Library.cs – Handles business logic (Add, Borrow, Return).

🔹 Views

  Index.cshtml – Displays the user interface and book listings.

🔹 Controllers

  LibraryController.cs – Manages HTTP requests and connects the model to the view.

# Core Features
1️. Add Book

  Users can add a book by entering:

   Title

   Author

  The book is automatically marked as available.

2️. Borrow Book

  Users can borrow a book, which updates its status to “Borrowed”.

3️. Return Book

  Users can return a borrowed book, restoring its status to “Available”.

# Key Concepts Demonstrated

   Encapsulation of data within classes

   Abstraction of business logic in the Library model

   Separation of concerns using MVC

   Basic CRUD-style operations

   Clean UI structuring with Razor

## ▶️ How to Run the Project

   Clone the repository

   Open the solution in Visual Studio

   Build the project

   Run using IIS Express or dotnet run

   Navigate to: https://localhost:{port}/Library

# Future Enhancements

   Database integration (SQL Server / MongoDB)

   Authentication & role management

   Search functionality

   Persistent storage

   Dashboard statistics
