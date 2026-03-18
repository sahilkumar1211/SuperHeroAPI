# 🦸 SuperHero API (ASP.NET Core + PostgreSQL)

A RESTful Web API built using ASP.NET Core and Entity Framework Core to manage SuperHero data with full CRUD operations.

---

## 🚀 Features

- Create, Read, Update, Delete (CRUD) operations
- Layered Architecture (Controller, Service, Data)
- Dependency Injection
- Entity Framework Core (Code First)
- PostgreSQL Database Integration
- Swagger UI for API testing

---

## 🛠️ Technologies Used

- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- PostgreSQL
- Swagger (OpenAPI)
- C#

---

## 🏗️ Project Structure
SuperHeroAPI/
│
├── Controllers/ → Handles HTTP requests
├── Services/ → Business logic layer
├── Models/ → Data models
├── Data/ → DbContext
├── Migrations/ → Database migrations
└── Program.cs → App configuration                                           

---

## 🔄 API Endpoints

| Method | Endpoint              | Description          |
|--------|----------------------|----------------------|
| GET    | /api/superhero       | Get all heroes       |
| GET    | /api/superhero/{id}  | Get hero by ID       |
| POST   | /api/superhero       | Add new hero         |
| PUT    | /api/superhero/{id}  | Update hero          |
| DELETE | /api/superhero/{id}  | Delete hero          |

---

## ⚙️ Setup Instructions

1. Clone the repository
```bash
git clone https://github.com/yourusername/SuperHeroAPI.git

2 Navigate to project folder
cd SuperHeroAPI

3. Update connection string in appsettings.json

4. Run migrations
Add-Migration Init
Update-Database

5. Run the project
dotnet run

6. CONCEPT USED
  Dependency Injection

  Separation of Concerns

  Layered Architecture

  REST API Design

  EF Core Code First Approach


7. Future Improvements

JWT Authentication

DTO Implementation

Logging & Exception Handling

Pagination & Filtering

Caching (Redis)
