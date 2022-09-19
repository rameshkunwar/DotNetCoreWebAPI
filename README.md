## .Net Core Web API with .Net Framework 3.1, EF Core, SQL Server 2019 or MySQL 5.7.29 or Sqlite

### This project was initially created using Visual Studio Code and later moved to Visual Studio 2019.

### This is just a demo project completed following tutorial by Les Jackson. Tutorial can be found [here](https://www.youtube.com/watch?v=fmvcAzHpsk8&t=10747s)

## How to use this project?

- Download the project.
- On terminal, `dotnet restore`
- On terminal, `dotnet run`

## MS SQL to MySQL

- Connection string changed in appsettings.json to MySQL.
  MS SQL connection string is `"Initial Catalog=CommanderDB; Data Source=DESKTOP-2ABFL9V;Integrated Security=True"`

## Additonal Nuget for MySQL

- Microsoft.EntityFrameworkCore.Tools v5.0.1
- Pomelo.EntityFrameworkCore.MySql (version 5.0.0-alpha.2)

## Database table generated using EF Core Code-First.
