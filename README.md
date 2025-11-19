# Task Manager API

A RESTful API built with ASP.NET Core as part of a Udemy course on building RESTful APIs with .NET Framework.

## Overview

This project is a simple Task Manager API that demonstrates RESTful API principles including CRUD operations, proper HTTP methods, and status codes.

## Features

- Create, Read, Update, and Delete task items
- RESTful endpoint design
- Built with ASP.NET Core Web API
- In-memory data storage

## Technologies Used

- .NET 8.0
- ASP.NET Core Web API
- C#

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code
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

3. Run the application:
   ```bash
   dotnet run --project TMApi
   ```

4. The API will be available at:
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
├── Models/
│   └── TaskItem.cs                # Data model
├── Program.cs                     # Application entry point
└── appsettings.json              # Configuration
```

## Learning Objectives

This project covers:
- RESTful API design principles
- HTTP methods (GET, POST, PUT, DELETE)
- Status codes and responses
- Controller-based routing
- Data models and validation

## License

This project is for educational purposes as part of a Udemy course.
