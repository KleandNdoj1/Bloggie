# Bloggie

ASP.NET Core 7 MVC blog platform with authentication, image uploads, likes, and comments.

## Features

- Blog post CRUD with rich text editor (Froala)
- Tag-based categorization
- Like and comment system per post
- Image upload via Cloudinary
- Role-based access: User, Admin, SuperAdmin
- ASP.NET Core Identity authentication

## Tech Stack

- **Framework:** ASP.NET Core 7 MVC
- **ORM:** Entity Framework Core 7 with SQL Server
- **Auth:** ASP.NET Core Identity (two separate databases)
- **Storage:** Cloudinary (image uploads)
- **Pattern:** Repository pattern with dependency injection

## Getting Started

### Prerequisites

- .NET 7 SDK
- SQL Server
- Cloudinary account (free tier works)

### Setup

1. Clone the repository
2. Copy `appsettings.Development.json.example` to `appsettings.Development.json` (or use [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets))
3. Fill in your connection strings and Cloudinary credentials
4. Run migrations:

```bash
dotnet ef database update --context BloggieDbContext
dotnet ef database update --context AuthDbContext
```

5. Run the application:

```bash
dotnet run --project Bloggie.Web
```

### Configuration

The following settings are required in `appsettings.Development.json` (never commit this file):

```json
{
  "ConnectionStrings": {
    "BloggieDbConnectionString": "Server=YOUR_SERVER;Database=BloggieDb;Trusted_Connection=True;TrustServerCertificate=Yes",
    "BloggieAuthDbConnectionString": "Server=YOUR_SERVER;Database=BloggieAuthDb;Trusted_Connection=True;TrustServerCertificate=Yes"
  },
  "Cloudinary": {
    "CloudName": "YOUR_CLOUD_NAME",
    "ApiKey": "YOUR_API_KEY",
    "ApiSecret": "YOUR_API_SECRET"
  }
}
```

### Default Admin Account

After running migrations, a SuperAdmin account is seeded automatically. Change the password on first login.

## Project Structure

```
Bloggie.Web/
├── Controllers/     # MVC + API controllers
├── Data/            # EF Core DbContexts and migrations
├── Models/
│   ├── Domain/      # Entity models
│   └── ViewModels/  # View-specific models
├── Repositories/    # Data access layer (interfaces + implementations)
└── Views/           # Razor views
```
