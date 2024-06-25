### Database setup localhost

#### Udemy

https://www.udemy.com/course/net-core-microservices-the-complete-guide-net-6-mvc/learn/lecture/38026870#overview

#### Docker local

1. Docker

```bash
   docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=migsid-dokwew-jofQu5' -p 1433:1433 --name sqlserver -d cagrin/azure-sql-edge-arm64

   docker ps
   ```

2. Test the connection:

   ```bash
   sqlcmd -S localhost,1433 -U sa -P migsid-dokwew-jofQu5
   ```

3. Azure data studio

```bash
   brew install --cask azure-data-studio
```

4. Azure data studio - connect to docker
   https://stackoverflow.com/questions/53150915/how-to-connect-docker-with-azure-data-studio

5. Update `appsettings.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=Mango_Coupon;User Id=sa;Password=migsid-dokwew-jofQu5;Encrypt=false"
  }
}
```

6. Database setup app

   ```bash
   dotnet ef migrations add Init
   dotnet ef database update
   ```

7. Database update. Used when updating models or to seed database at start

   ```bash
   dotnet ef migrations add UpdateCouponModel
   dotnet ef database update
   ```
