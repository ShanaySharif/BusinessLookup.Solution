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


Within appsettings.Development.json, add the following code:
``` {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
} 

```

- Create the database using the migrations in the BusinessApi Park API project. 
- Open your shell (e.g., Terminal or GitBash) to the production directory "BusinessAPI", and run dotnet ef database update.
- To optionally create a migration, run the command dotnet ef migrations add MigrationName where MigrationName is your custom name for the migration in UpperCamelCase. 
- Within the production directory "BusinessAPI", run dotnet watch run --launch-profile "BusinessAPI-Production" in the command line to start the project in production mode with a watcher.
- To optionally further build out this project in development mode, start the project with dotnet watch run in the production directory "BusinessAPI".
- Use your program of choice to make API calls. In your API calls, use the domain http://localhost:5000.

## How to Obtain a Token:
- to obtain a Token in Swagger UI, Navigate to the top of the page where it says Auth.
- Under the Post action click the drop down Post/api/register button.
- Right under Request Body, you'll see

 ```{
  "username": "string",
  "password": "string"
}
```

- where it says "string" type in a username and password of your choice.

- Next, Navigate to the POST dropdown under POST
​/api​/Auth​/register that says POST
​/api​/Auth​/login.
```
 {
  "username": "string",
  "password": "string"
}
```
- Type in the username and password you selected above.
- It will generate a token order
- Copy and past Token into API request of your choice.


### How to authenticate using a token. 

To authenticate a token in Postman, you can follow these general steps:

- Create a Request:
-Create a new request in Postman to the API endpoint you want to access.

Select Authorization Type:
-In the request tab, navigate to the "Authorization" tab.

Choose Token-Based Authorization:
-In the "Type" dropdown, select the appropriate token-based authorization type. This could be "Bearer Token" or something similar, depending on the API you're working with.

Provide Token:
-Once you've selected the authorization type, a field will appear where you can enter the token. This is usually a field called "Token" or "Bearer Token". Enter the token you've received from the authentication process.

Send Request:
- After adding the token, you can proceed to send the request. The token will be included in the request headers, which will authenticate your request with the API server.


## Testing the API Endpoints
- You are welcome to test this API via Postman, Swagger UI, curl, or the ASP.NET Core MVC.

- Available Endpoints
- GET http://localhost:5000/api/Businesses/
- GET http://localhost:5000/api/Businesses/search
- POST http://localhost:5000/api/create/
- PUT http://localhost:5000/api/Businesses/{id}
- DELETE http://localhost:5000/api/Businesses/{id}
Note: {id} is a variable and it should be replaced with the id number of the Business you want to GET, PUT, or DELETE.


GET http://localhost:5000/api/businesses?rating=9
- The following query will return all business with a rating of 9

GET http://localhost:5000/api/businesses?locationName=columbus
- The following query will return all businesses located in Columbus

GET http://localhost:5000/api/businesses?restaurantName=Mozart's
- The following query will return all the data relating to Mozart Restaurant.

When making a POST request to http://localhost:5000/api/businesses/, you need to include a body. Here's an example body in JSON:

``` "restaurantName": "Fox in the Snow Cafe",
        "locationName": "New Albany",
        "review": "Best Cafe Art in town",
        "rating": 10
```
Additional Requirements for PUT Request
- When making a PUT request to http://localhost:5000/api/animals/{id}, you need to include a body that includes the animal's animalId property. Here's an example body in JSON:

```
 "businessId": 4,
    "restaurantName": "Zencha Cafe",
    "locationName": "High St",
    "review": "Masala Chai waffles were the lightest crispiest waffles ever chicken dumping looked ordinary but tasted heavenly",
    "rating": 8
```
And here's the PUT request we would send the previous body to:

http://localhost:5000/api/businesses/4
Notice that the value of businessId needs to match the id number in the URL. In this example, they are both 4.

### Optional Query String Parameters for GET Request
- GET requests to http://localhost:5000/api/Businesses/ can optionally include query strings to filter or search Businesses.



## Known Bugs
No known bugs 
## MIT License
Copyright (c) 2023 Shankaron Mohamed

