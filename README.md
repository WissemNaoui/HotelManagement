# Hotel Management System

## Overview
A comprehensive .NET 8.0 web application for hotel reservation and management, built using Clean Architecture principles.

## Features
- Customer Management
- Room Reservation System
- Room Inventory Tracking

## Technologies
- .NET 8.0
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server
- Visual Studio or VS Code

### Installation
1. Clone the repository
2. Update connection string in `appsettings.json`
3. Run database migrations
```bash
dotnet ef database update
```

## Project Structure
- `HotelManagement.Domain`: Core domain entities
- `HotelManagement.Application`: Business logic
- `HotelManagement.Infrastructure`: Data access and external integrations
- `HotelManagement.Api`: Web API endpoints

## Contributing
1. Fork the repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License
[Specify your license]
