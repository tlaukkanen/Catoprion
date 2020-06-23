# Caprion - .NET Core/React Blog

Caprion is a opinioned blog engine mainly to run my own blog [codeof.me](https://codeof.me). Application is built on the following technologies:

**Backend (.NET Core):**
* [Piranha CMS](https://piranhacms.org/) for content management
* GraphQL API for pages and posts
* (Azure) SQL Server and Blob Storage for persistent storage

**Front-end (React SPA):**
* React App
* Material UI framework for UI components

# Development

Requirements for local development:
* Docker and docker-compose (for running SQL Server and Azure Blob emulator)
* .NET Core (and dotnet CLI)
* Node.js (for building React app)

## Starting up

* Start SQL Server and Azure Blob emulator `docker-compose up`
* Run Entity Framework migrations `dotnet ef database update --context Piranha.Data.EF.SQLServer.SQLServerDb`
* Start the project `dotnet run`
* Load login page from http://localhost:5002/manager/
* Login with `admin` and `password` credentials
