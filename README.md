# Todo API (.NET 10 Clean Architecture)

## Overview

This project is a RESTful Todo API built with **.NET 10** following **Clean Architecture** principles. It provides CRUD operations for managing Todo items while maintaining a clear separation of concerns between the API, Application, Domain, and Infrastructure layers.

The application currently uses an **In-Memory Database** for data storage, making it easy to run without any external database setup.

---

## Technology Stack

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- Entity Framework Core In-Memory Database
- Clean Architecture
- Dependency Injection
- Swagger / OpenAPI

---

## Project Structure

```
TodoAPI360Degree
│
├── TODO360Degree.API
├── TODO360Degree.Application
├── TODO360Degree.Domain
├── TODO360Degree.Infrastructure
├── TODO360Degree.Tests
│
└── TodoAPI360Degree.sln
```

---

## Architecture

The solution follows the **Clean Architecture** pattern.

```
Presentation (API)
        │
        ▼
Application
        │
        ▼
Domain
        ▲
        │
Infrastructure
```

### Layer Responsibilities

### API

- REST API Controllers
- Dependency Injection
- Middleware
- Swagger Configuration

### Application

- Business Logic
- DTOs
- Interfaces
- Services

### Domain

- Entities
- Domain Models
- Business Rules

### Infrastructure

- Entity Framework Core
- In-Memory Database Configuration
- Repository Implementations

### Tests

A test project has been created for future unit testing.

---

## Prerequisites

Install the following before running the application:

- .NET 10 SDK
- Visual Studio 2022 (17.14 or later) or Visual Studio Code

---

## Getting Started

### Clone the repository

```bash
git clone <repository-url>
```

### Navigate to the solution

```bash
cd TodoAPI360Degree
```

### Restore packages

```bash
dotnet restore
```

### Build the solution

```bash
dotnet build
```

### Run the API

```bash
dotnet run --project TODO360Degree.API
```

---

## API Documentation

Once the application is running, open:

```
https://localhost:<port>/swagger
```

Swagger provides interactive documentation for all available API endpoints.

---

## Features

- Create Todo
- Retrieve all Todos
- Retrieve Todo by Id
- Update Todo
- Delete Todo
- Dependency Injection
- Clean Architecture
- In-Memory Database
- Swagger UI

---

## Testing

A test project (`TODO360Degree.Tests`) has been included in the solution for future unit testing.

At the time of submission, no unit tests have been implemented.

---

## Design Principles

- Clean Architecture
- SOLID Principles
- Separation of Concerns
- Dependency Injection

---

## Build

```bash
dotnet build
```

---

## Author

Developed as part of the **360 Degree Cloud Technical Assessment** using **.NET 10** and **Clean Architecture**.
