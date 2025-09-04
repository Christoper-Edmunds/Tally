# Tally

Tally is a multiplatform application for preventing food waste, designed to make it easy to add and remove items, and to display data that communicates the age and likelihood of expiry for tracked items.

**Now powered by PostgreSQL for all environments!**

Deployable locally on Windows and Linux via a desktop application (with system tray integration), accessible via web browsers, hostable on AWS, and available on mobile platforms.

---

## Core Architecture

### Backend

- **ASP.NET Core** — Cross-platform, high-performance framework
- **Entity Framework Core** — ORM for database access
- **PostgreSQL** (local & cloud) — Primary database engine (replaces SQL Server/SQL Azure)
- **Push Notification Service Integration** (e.g., FCM, APNS, Azure Notification Hubs) — For real-time and background notifications to mobile and supporting clients

### Frontend

- **Blazor WebAssembly** — Single codebase for web client
- **.NET MAUI** with Blazor components — Mobile apps sharing UI logic

### Desktop Application

- **Electron.NET** — Desktop integration with toolbar/tray functionality
- **SignalR** — Real-time updates across clients
- **(Optional) Push Notification Support** — For supported desktop platforms

---

## Architecture Diagram

```
┌────────────────────────────────────────────┐
│                Client Layer                │
├───────────┬───────────────┬─────────────┬──┤
│ Electron  │ Web Browsers  │ Mobile Apps │  │
│ Desktop   │ (Blazor WASM) │ (.NET MAUI) │  │
└─────┬─────┴───────┬───────┴──────┬──────┘  │
      │             │              │         │
      │             │              │         │
      │             │     ┌────────▼─────────▼─────┐
      │             │     │  Push Notification     │
      │             │     │      Service           │
      │             │     │ (e.g., FCM/APNS/Azure) │
      │             │     └────────┬───────────────┘
      │             │              │
      │     ┌───────▼──────────────▼─────┐
      │     │    API Layer (REST/gRPC)   │
      └─────►       ASP.NET Core         │
            └────────────┬───────────────┘
                         │
            ┌────────────▼───────────────┐
            │      Business Layer        │
            │   (Services, Validation)   │
            └────────────┬───────────────┘
                         │
            ┌────────────▼───────────────┐
            │       Data Access          │
            │     Entity Framework       │
            └────────────┬───────────────┘
                         │
            ┌────────────▼───────────────┐
            │        Database            │
            │        PostgreSQL          │
            └────────────────────────────┘
```
## Storage
```
┌───────────────┐  ┌───────────────┐
│   Electron    │  │  Mobile App   │
│  (Desktop)    │  │ (.NET MAUI)   │
└──────┬────────┘  └──────┬────────┘
       │                   │
┌──────▼────────┐    ┌─────▼──────────┐
│ Local Storage │    │ Local Storage  │
│ (SQLite/DB)   │    │ (SQLite)       │
└──────┬────────┘    └─────┬──────────┘
       │                   │
   (Sync Layer: bidirectional)
       │                   │
┌──────▼───────────────────▼───────┐
│         API Layer (Cloud DB)     │
└──────────────────────────────────┘
```

## Project Structure

```
Tally/
├── Tally.Api/                 # ASP.NET Core API project
├── Tally.Core/                # Shared models and business logic
├── Tally.Data/                # EF Core and database access
├── Tally.Desktop/             # Electron.NET application
├── Tally.Web/                 # Blazor WebAssembly project
├── Tally.Mobile/              # .NET MAUI project
├── Tally.Notifications/       # Push notification integration (shared logic/services)
└── Tally.Tests/               # Unit and integration tests
```

---

## Deployment Models

### Local Desktop Deployment

- Electron.NET bundles the ASP.NET Core API and web client
- Uses **PostgreSQL** for data storage (can run locally via Docker or native install)
- Runs in system tray with browser access for local network clients
- Supports Windows and Linux environments

### AWS Cloud Deployment

- API hosted in AWS Elastic Beanstalk or ECS
- Database on Amazon RDS (PostgreSQL)
- Static web assets in S3/CloudFront
- API Gateway for REST endpoints
- Cognito for user authentication
- Push notifications sent via AWS SNS or integrated service

### Mobile Apps

- Native apps using .NET MAUI accessing same backend APIs
- Shared Blazor components for UI consistency
- Offline support with local SQLite and sync capabilities
- Available for Android and iOS platforms
- Push notifications delivered via FCM (Android) and APNS (iOS)

---

## Deployment Workflow

### Local Development

1. Clone repository
2. Run `dotnet restore` to restore dependencies
3. Set up local PostgreSQL database (see below)
4. Run Entity Framework migrations:  
   `dotnet ef database update --project Tally.Data`
5. Start API:  
   `dotnet run --project Tally.Api`
6. Start client:  
   `dotnet run --project Tally.Web`
7. For desktop app:  
   `electronize start` in the Desktop project directory

#### Setting up PostgreSQL locally

- With Docker:
  ```bash
  docker run --name tally-postgres -e POSTGRES_PASSWORD=yourpassword -p 5432:5432 -d postgres:15
  ```
- Or install PostgreSQL natively (see [PostgreSQL downloads](https://www.postgresql.org/download/))

- Edit your `appsettings.Development.json` to set the connection string, for example:
  ```json
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=tally;Username=postgres;Password=yourpassword"
  }
  ```

### Desktop Application Build

```bash
# Windows
electronize build /target win

# Linux
electronize build /target linux
```

### Cloud Deployment

```bash
# Deploy API to AWS Elastic Beanstalk
dotnet publish -c Release
eb deploy

# Deploy frontend assets to S3
aws s3 sync ./Tally.Web/dist/ s3://your-bucket-name/
```

### Mobile Deployment

```bash
# Build Android App
dotnet build -f net7.0-android -c Release

# Build iOS App
dotnet build -f net7.0-ios -c Release
```

### Push Notification Configuration

- Register app with FCM (Android) or APNS (iOS)
- Configure notification keys/tokens in API and mobile projects
- Set up notification triggers in the business logic layer (e.g., item about to expire)
- Test notifications on supported clients

---

## Iterative Development Plan

### Phase 1: Core API and Data Layer (8–10 weeks)
- Develop ASP.NET Core Web API project
- Implement Entity Framework Core data models
- Create user authentication/authorization system
- Build core business logic for users and items management
- Set up initial database with PostgreSQL
- Create automated tests for API endpoints

**Milestone:** Functioning REST API with PostgreSQL access and complete business logic

### Phase 2: Web Application (4–6 weeks)
- Build Blazor WebAssembly frontend
- Create responsive UI for desktop/mobile browsers
- Implement all CRUD operations for users/items
- Add authentication flow in the UI
- Deploy locally for testing

**Milestone:** Complete web application running on localhost

### Phase 3: Electron Desktop Integration (3–4 weeks)
- Integrate Electron.NET wrapper around the web application
- Add system tray functionality and auto-start options
- Configure for local network access
- Set up SQLite for offline operation (optional)
- Create installer packages for Windows and Linux

**Milestone:** Functioning desktop application with system tray integration

### Phase 4: Cloud Deployment (2–3 weeks)
- Set up AWS infrastructure (via Terraform or CloudFormation)
- Configure RDS for PostgreSQL
- Implement environment-specific configurations
- Set up CI/CD pipeline for automated deployments
- Add monitoring and logging
- Implement database migration strategy

**Milestone:** Cloud-hosted version accessible on the internet

### Phase 5: Mobile Applications (6–8 weeks)
- Create .NET MAUI project sharing business logic from core
- Reuse Blazor components where possible
- Implement native mobile UI elements
- Add offline capabilities with local SQLite storage
- Set up sync mechanisms between local and cloud data
- Configure push notifications for critical updates (item expiry, inventory changes)

**Milestone:** Mobile applications published to app stores, with push notification support

### Phase 6: Integration and Polish (3–4 weeks)
- Implement cross-device synchronization
- Refine UI/UX across all platforms
- Performance optimization and security hardening
- User acceptance testing
- Documentation and support materials

**Milestone:** Fully integrated cross-platform ecosystem

---

## Key Technical Benefits

1. **Code Reuse**: The same C# business logic and data models are shared across platforms
2. **Simplified Authentication**: ASP.NET Core Identity works across web, desktop, and mobile
3. **Offline Capability**: Local database with syncing capabilities
4. **Push Notifications**: Timely alerts for item expiry or inventory changes, especially on mobile
5. **Scalability**: Easy migration from self-hosted to cloud-hosted environments
6. **System Tray Integration**: Electron.NET provides robust toolbar/tray functionality
7. **Cross-Platform Support**: Runs on Windows, Linux, Android, iOS, and web browsers
8. **PostgreSQL Support**: Modern, robust, and open-source database for all deployment scenarios

---

## Getting Started

See the [Development Setup Guide](./docs/development-setup.md) for instructions on setting up your development environment and running the application locally.

---

## License

[MIT License](./LICENSE)

---

## Contributors

- [Your Name](https://github.com/yourusername)
