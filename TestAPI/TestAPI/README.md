1. Open NuGet Package Manager Console
 
2. Change ConnectionStrings Server in appsettings.Development.json
3. Run next commands
	EntityFrameworkCore\Enable-Migrations
	EntityFrameworkCore\Add-Migration Init
	EntityFrameworkCore\Update-Database

4. Run TestAPI Project
