# 🛍 Shanta

A scalable and modular ERP system, built using **Onion Architecture** with .NET technologies. Designed to support clean code separation, extensibility, and maintainability.

## 📦 Architecture Overview

This solution adopts **Onion Architecture**, structured into clear layers:
```bash
Talabat.Solution/
│
├── Talabat.APIs # ASP.NET Core Web API layer
├── Talabat.Core # Domain entities & contracts
├── Talabat.Repository # Infrastructure: EF Core, Redis
└── Talabat.Services # Application services, business logic
```

### 🔁 Technologies & Tools

- **ASP.NET Core** - Web API
- **Entity Framework Core** - ORM
- **Clean Separation** - via Onion Architecture principles

---
