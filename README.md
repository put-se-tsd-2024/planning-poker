# Planning Poker

## Team Members

- **Agnieszka Grzymska**
- **Andrei Staravoitou**
- **Bartosz Chwiłkowski**
- **Ivan Haidov**


## Project Overview

This is a planning poker application developed using the Blazor framework. The application facilitates agile project planning by allowing teams to estimate the effort required for various tasks interactively.

## Tools Required

- **.NET**: For building and running the application.
- **Blazor**: For building the client-side web UI.
- **Entity Framework Core**: For database operations.
- **SQL Server**: As the database.
- **Azure**: For deploying the application (optional, for production deployment).

## Project Configuration

### Database Setup

1. Install SQL Server and create a new database.
2. Update the connection string in the `appsettings.json` file located in the `Server` folder:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "User Id=postgres.rcbzzqgkhbemngykoozi;Password=J5f87lMOoIEdk0IK;Server=aws-0-eu-central-1.pooler.supabase.com;Port=5432;Database=postgres;"
    }
    ```
3. Run the following commands to apply migrations and update the database:
    ```sh
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

### Web Server Setup

1. Navigate to the `Server` folder.
2. Execute the following command to run the server:
    ```sh
    dotnet run
    ```

## To run the project as it is:

1) go to ../Server/ folder 
2) execute "dotnet run" command

## The deployed application is available here:

https://planningpokerapp.azurewebsites.net/
 
