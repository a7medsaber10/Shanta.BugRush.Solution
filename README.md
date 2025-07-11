# 🛍 Shanta

A scalable and modular ERP system, built using **Onion Architecture** with .NET technologies. Designed to support clean code separation, extensibility, and maintainability.

## 📦 Architecture Overview

This solution adopts **Onion Architecture**, structured into clear layers:
```bash
Talabat.Solution/
│
├── Shanta.APIs # ASP.NET Core Web API layer
├── Shanta.Core # Domain entities & contracts
├── Shanta.Repository # Infrastructure: EF Core, Redis
└── Shanta.Services # Application services, business logic
```

### 🔁 Technologies & Tools

- **ASP.NET Core** - Web API
- **Entity Framework Core** - ORM
- **AutoMapper** - DTO ↔ Entity mapping
- **Clean Separation** - via Onion Architecture principles

---

## ⚙️ Getting Started

### 🧰 Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)
- SQL Server (or alternative EF-compatible DB)

### 📥 Clone the Repo

```bash
git clone https://github.com/a7medsaber10/Shanta.BugRush.Solution.git
cd Shanta.BugRush.Solution
```

### 🔧 Configuration
Edit appsettings.json in Shanta.APIs:
```bash
"ConnectionStrings": {
  "DefaultConnection": "Your_SQL_Connection_String"
}
```

### 🛠️ Database Setup
Apply migrations and create the DB:

```bash
cd Shanta.APIs
dotnet ef database update
```

### ▶️ Run the App
```bash
dotnet run --project Shanta.APIs
```
Visit https://localhost:{port}/swagger for interactive API docs.

---

### 👨‍💻 Authors

**Ahmed Saber**
- **GitHub**: https://github.com/a7medsaber10
- **Linkedin**: https://www.linkedin.com/in/a7medsaber10
- **Email**: ahmedsa2522003@gmail.com

**Ahmed Ibrahim**
- **GitHub**: 
- **Linkedin**: 
- **Email**: 

