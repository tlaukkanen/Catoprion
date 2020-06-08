# Headless Piranha CMS for Blogs

This is a simple headless CMS for blogs based using Piranha CMS.

# Development

Requirements:
* Docker and docker-compose (for running SQL Server and Azure Blob emulator)
* .NET Core (and dotnet CLI)

## Starting up

* Start SQL Server and Azure Blob emulator `docker-compose up`
* Run Entity Framework migrations `dotnet ef database update --context Piranha.Data.EF.SQLServer.SQLServerDb`
* Start the project `dotnet run`
* Load login page from http://localhost:5002/manager/
* Login with `admin` and `password` credentials
