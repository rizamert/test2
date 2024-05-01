# Database Migrations

## Applying Migrations

### ApplicationDbContext Migrations
1. **Creating Migrations**

   ```bash
   dotnet ef migrations add InitialCreate --project .\Remx.Infrastructure.Ef --startup-project .\Remx.Api --context ApplicationDbContext -v
2. **Updating the Database**
    
   ```bash
    dotnet ef database update --project .\Remx.Infrastructure.Ef --startup-project .\Remx.Api --context ApplicationDbContext -v
