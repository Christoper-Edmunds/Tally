# Tally
Multiplatform application for preventing food waste, designed to focus on ease of adding and removing items and displaying data in a manner which is communicative about the items age and likelyness to go off

Deployable locally on Windows and Linux via desktop application (with system tray integration), accessible via web browsers, hostable on AWS, and available on mobile platforms.

## Core Architecture

### Backend
- **ASP.NET Core** - Cross-platform, high-performance framework
- **Entity Framework Core** - ORM for database access
- **SQL Server Express LocalDB** (local) / **SQL Azure** (cloud) - Database

### Frontend
- **Blazor WebAssembly** - Single codebase for web client
- **.NET MAUI** with Blazor components - Mobile apps sharing UI logic

### Desktop Application
- **Electron.NET** - Desktop integration with toolbar/tray functionality
- **SignalR** - Real-time updates across clients

## Architecture Diagram

```
┌─────────────────────────────────────────┐
│             Client Layer                │
├───────────┬───────────────┬─────────────┤
│ Electron  │ Web Browsers  │ Mobile Apps │
│ Desktop   │ (Blazor WASM) │ (.NET MAUI) │
└─────┬─────┴───────┬───────┴──────┬──────┘
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
            │  SQL Server/SQL Azure      │
            └────────────────────────────┘
```

## Project Structure

```
YourApp/
├── YourApp.Api/              # ASP.NET Core API project
├── YourApp.Core/             # Shared models and business logic
├── YourApp.Data/             # EF Core and database access
├── YourApp.Desktop/          # Electron.NET application
├── YourApp.Web/              # Blazor WebAssembly project
├── YourApp.Mobile/           # .NET MAUI project
└── YourApp.Tests/            # Unit and integration tests
```

## Deployment Models

### Local Desktop Deployment
- Electron.NET bundles the ASP.NET Core API and web client
- Uses SQL Server Express LocalDB for data storage
- Runs in system tray with browser access for local network clients
- Supports Windows and Linux environments

### AWS Cloud Deployment
- API hosted in AWS Elastic Beanstalk or ECS
- Database on Amazon RDS (SQL Server)
- Static web assets in S3/CloudFront
- API Gateway for REST endpoints
- Cognito for user authentication

### Mobile Apps
- Native apps using .NET MAUI accessing same backend APIs
- Shared Blazor components for UI consistency
- Offline support with local SQLite and sync capabilities
- Available for Android and iOS platforms

## Deployment Workflow

### Local Development
1. Clone repository
2. Run `dotnet restore` to restore dependencies
3. Set up local database with `dotnet ef database update`
4. Start API with `dotnet run` in the API project directory
5. Start client with `dotnet run` in the Web project directory
6. For desktop app: `electronize start` in the Desktop project directory

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
aws s3 sync ./YourApp.Web/dist/ s3://your-bucket-name/
```

### Mobile Deployment
```bash
# Build Android App
dotnet build -f net7.0-android -c Release

# Build iOS App
dotnet build -f net7.0-ios -c Release
```

## Iterative Development Plan

### Phase 1: Core API and Data Layer (8-10 weeks)
- Develop ASP.NET Core Web API project
- Implement Entity Framework Core data models
- Create user authentication/authorization system
- Build core business logic for users and items management
- Set up initial database with SQL Server Express/LocalDB
- Create automated tests for API endpoints

**Milestone**: Functioning REST API with database access and complete business logic

### Phase 2: Web Application (4-6 weeks)
- Build Blazor WebAssembly frontend
- Create responsive UI that works on desktop and mobile browsers
- Implement all CRUD operations for users and items
- Add authentication flow in the UI
- Deploy locally for testing

**Milestone**: Complete web application running on localhost

### Phase 3: Electron Desktop Integration (3-4 weeks)
- Integrate Electron.NET wrapper around the web application
- Add system tray functionality
- Implement auto-start options
- Configure for local network access
- Set up SQLite/LocalDB for offline operation
- Create installer packages for Windows and Linux

**Milestone**: Functioning desktop application with system tray integration

### Phase 4: Cloud Deployment (2-3 weeks)
- Set up AWS infrastructure (via Terraform or CloudFormation)
- Configure RDS for SQL database
- Implement environment-specific configurations
- Set up CI/CD pipeline for automated deployments
- Add monitoring and logging
- Implement database migration strategy

**Milestone**: Cloud-hosted version accessible on the internet

### Phase 5: Mobile Applications (6-8 weeks)
- Create .NET MAUI project sharing business logic from core
- Reuse Blazor components where possible
- Implement native mobile UI elements
- Add offline capabilities with local SQLite storage
- Set up sync mechanisms between local and cloud data
- Configure push notifications

**Milestone**: Mobile applications published to app stores

### Phase 6: Integration and Polish (3-4 weeks)
- Implement cross-device synchronization
- Refine UI/UX across all platforms
- Performance optimization
- Security hardening
- User acceptance testing
- Documentation and support materials

**Milestone**: Fully integrated cross-platform ecosystem

## Key Technical Benefits

1. **Code Reuse**: The same C# business logic and data models shared across platforms
2. **Simplified Authentication**: ASP.NET Core Identity works across web, desktop, and mobile
3. **Offline Capability**: Local database with syncing capabilities
4. **Scalability**: Easy migration path from self-hosted to cloud-hosted
5. **System Tray Integration**: Electron.NET provides robust toolbar/tray functionality
6. **Cross-Platform Support**: Runs on Windows, Linux, Android, iOS, and web browsers

## Getting Started

See the [Development Setup Guide](./docs/development-setup.md) for instructions on setting up your development environment and running the application locally.

## License

[MIT License](./LICENSE)

## Contributors

- [Your Name](https://github.com/yourusername)
