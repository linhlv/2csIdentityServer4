linh.le@2clicksolutions.com
P@ssw0rd!


dotnet ef migrations add CreateIdentitySchema

dotnet ef database update -c ApplicationDbContext

dotnet ef migrations add MigrationName -s "..\01_Agency.API\01_Agency.API.csproj"


dotnet ef database update -s "..\01_Agency.API\01_Agency.API.csproj"