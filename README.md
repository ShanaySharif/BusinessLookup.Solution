# BusinessLookup.Solution

## By Shankaron Mohamed


## Utilized Technologies
- C#
- Git
- MySQL Workbench
- Enity Framework Core
- ASP.NET Core MVC
- HTML & CSS
- Razor
- Bootstrap

 ## Setup

- Install the dotnet-ef tool by running the following command in your terminal:

- dotnet tool install --global dotnet-ef --version 6.0.0
- Set Up and Run Project
- Clone this repo.
- Open the terminal and navigate to this project's production directory called "BusinessLookup.Solution".
Within the production directory "BusinessApi", create two new files: appsettings.json and appsettings.Development.json.
Within appsettings.json, put in the following code. Make sure to replacing the uid and pwd values in the MySQL database connection string with your own username and password for MySQL.
  ``` {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=Business_api;uid=root;pwd=epicodus;"
  }
}
Within appsettings.Development.json, add the following code:
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
} ```

Create the database using the migrations in the BusinessApi Park API project. Open your shell (e.g., Terminal or GitBash) to the production directory "BusinessAPI", and run dotnet ef database update.
To optionally create a migration, run the command dotnet ef migrations add MigrationName where MigrationName is your custom name for the migration in UpperCamelCase. 
Within the production directory "BusinessAPI", run dotnet watch run --launch-profile "BusinessAPI-Production" in the command line to start the project in production mode with a watcher.
To optionally further build out this project in development mode, start the project with dotnet watch run in the production directory "BusinessAPI".
Use your program of choice to make API calls. In your API calls, use the domain http://localhost:5000.
Testing the API Endpoints
You are welcome to test this API via Postman, curl, or the ASP.NET Core MVC.

- Available Endpoints
- GET http://localhost:5000/api/Businesses/
- GET http://localhost:5000/api/Businesses/search
- POST http://localhost:5000/api/create/
- PUT http://localhost:5000/api/Businesses/{id}
- DELETE http://localhost:5000/api/Businesses/{id}
Note: {id} is a variable and it should be replaced with the id number of the Business you want to GET, PUT, or DELETE.

### Optional Query String Parameters for GET Request
- GET requests to http://localhost:5000/api/Businesses/ can optionally include query strings to filter or search Businesses.


