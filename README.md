# Task Manager API

A RESTful API built with ASP.NET Core as part of a Udemy course on building RESTful APIs with .NET Framework.

## Overview

This project is a simple Task Manager API that demonstrates RESTful API principles including CRUD operations, proper HTTP methods, and status codes.

## Features

- Create, Read, Update, and Delete task items
- RESTful endpoint design
- Built with ASP.NET Core Web API
- Entity Framework Core for data persistence
- SQL Server LocalDB for database storage
- Repository pattern implementation
- Async/await operations for better performance

## Technologies Used

- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core 9.0
- SQL Server LocalDB
- C#

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code
- SQL Server LocalDB (included with Visual Studio)
- Postman (for testing API endpoints)

### Running the Application

1. Clone the repository:
   ```bash
   git clone https://github.com/David-Echevarria24/Udemy-Course-RestfulApis.git
   ```

2. Navigate to the project directory:
   ```bash
   cd TMApi
   ```

3. Apply database migrations:
   ```bash
   dotnet ef database update --project TMApi
   ```

4. Run the application:
   ```bash
   dotnet run --project TMApi
   ```

5. The API will be available at:
   - HTTPS: `https://localhost:7xxx`
   - HTTP: `http://localhost:5xxx`

5. Use Postman to test the API endpoints

## Testing with Postman

Import the API endpoints into Postman or manually create requests:

1. Open Postman
2. Create a new request
3. Use the endpoints listed below with the appropriate HTTP methods
4. Set the base URL to your localhost address (e.g., `https://localhost:7xxx`)

## API Endpoints

### Task Items

- `GET /api/taskitems` - Get all task items
- `GET /api/taskitems/{id}` - Get a specific task item
- `POST /api/taskitems` - Create a new task item
- `PUT /api/taskitems/{id}` - Update an existing task item
- `DELETE /api/taskitems/{id}` - Delete a task item

## Project Structure

```
TMApi/
├── Controllers/
│   └── TaskItemsController.cs    # API endpoints
├── Data/
│   └── ApiDbContext.cs           # Entity Framework DbContext
├── Interface/
│   └── ITaskRepository.cs        # Repository interface
├── Migrations/                    # EF Core migrations
│   ├── 20251120002246_InitialCreate.cs
│   ├── 20251120002246_InitialCreate.Designer.cs
│   └── ApiDbContextModelSnapshot.cs
├── Models/
│   └── TaskItem.cs               # Data model
├── Repositories/
│   └── TaskRepository.cs         # Repository implementation
├── Program.cs                    # Application entry point
└── appsettings.json              # Configuration
```

## Database

The application uses SQL Server LocalDB with the following connection string:
- **Server**: `(localdb)\\MSSQLLocalDB`
- **Database**: `TaskManagementDB`
- **Authentication**: Integrated Security

### TaskItem Schema

| Column      | Type      | Description                    |
|-------------|-----------|--------------------------------|
| Id          | int       | Primary key (auto-increment)   |
| Title       | string    | Task title                     |
| Description | string    | Task description               |
| CreatedAt   | DateTime  | Timestamp of creation          |

## Learning Objectives

This project covers:
- RESTful API design principles
- HTTP methods (GET, POST, PUT, DELETE)
- Status codes and responses
- Controller-based routing
- Data models and validation
- Entity Framework Core integration
- Database migrations
- Repository pattern
- Async/await operations
- SQL Server database connectivity

## License

This project is for educational purposes as part of a Udemy course.
