# Library Management System

A simple console-based library management system implemented in C# that demonstrates OOP concepts, SOLID principles, and design patterns.

## Features

- Add regular books and eBooks
- Remove books using ISBN
- Search books by title
- List all available books
- Display file size for eBooks

## How to Run

1. Open the solution in Visual Studio
2. Press F5 or click the Start button (green play button)
3. Follow the on-screen menu options

## Design Patterns Used

- Singleton Pattern: Used in LibraryManager class
- Factory Pattern: Used in BookFactory class for creating book objects

## SOLID Principles Implementation

- Single Responsibility: Each class has one specific purpose
- Open/Closed: Book class is extensible (EBook inherits from it)
- Liskov Substitution: EBook can be used wherever Book is used
- Interface Segregation: ILibrary interface defines core operations
- Dependency Inversion: LibraryManager depends on ILibrary interface

## Project Structure

```
LibraryManagementSystem/
├── Models/
│   ├── Book.cs
│   └── EBook.cs
├── Interfaces/
│   └── ILibrary.cs
├── Services/
│   ├── Library.cs
│   └── LibraryManager.cs
├── Factory/
│   └── BookFactory.cs
└── Program.cs
```

## Class Descriptions

### Models
- `Book.cs` - Base class for books with basic properties like title, author, ISBN
- `EBook.cs` - Derived class that extends Book with additional file size property

### Interfaces
- `ILibrary.cs` - Defines core operations for the library system

### Services
- `Library.cs` - Implements ILibrary interface with book management operations
- `LibraryManager.cs` - Singleton class that manages the library operations

### Factory
- `BookFactory.cs` - Factory class for creating Book and EBook objects

### Root
- `Program.cs` - Main entry point with console UI implementation
