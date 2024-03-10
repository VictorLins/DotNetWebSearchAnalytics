# Products API Documentation

Welcome to the Products API repository!
The aim of this repository is to provide API access to **Product** information using Microsoft Identity and JWT authentication.
This repository also includes some unit and integration tests and a Client application for convenient testing.

The following technologies and tools were utilized:

![image](https://github.com/VictorLins/DotNetWebSearchAnalyticsAPI/assets/15841201/8338ccec-1948-4aec-abf5-0f56cf8a25ca)


The solution was structured as per below:

![image](https://github.com/VictorLins/DotNetWebSearchAnalyticsAPI/assets/15841201/cdbdd3c2-7eea-4bcc-8b51-033bc4e2829c)


## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [API Documentation](#APIDocumentation)
- [Client Application](#clientApp)

## Getting Started

### Prerequisites

Before running the API, ensure you have the following installed:

- .NET 7 SDK: [Download here](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 22: [Download here](https://visualstudio.microsoft.com/vs/)
- SQL Server Express Edition

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/VictorLins/DotNetWebSearchAnalyticsAPI.git
   ```

2. Configure the Connection String in the API project (DotNetWebSearchAnalyticsAPI.Api\appsettings.json)

   For test purposes, the following connection string was used, with the password intentionally visible

   ```bash
      "ConnectionStrings": {  "DefaultConnection": "Server=.\\SQLExpress;Database=AuthDemoDb;User Id=sa;Password=Password123;MultipleActiveResultSets=True;TrustServerCertificate=True;"},
   ```
   
4. Open Package Manager Console > Select project "DotNetWebSearchAnalyticsAPI" > run the following commands: 
   ```bash
   Add-Migration DotNetWebSearchAnalyticsAPI
   ```
   ```bash
   Update-Database
   ```

5. Use the following script to add Mock data into the database:
   ```sql
   INSERT INTO AuthDemoDb.dbo.Products (Name, Colour, Price)
   VALUES
   ('Laptop', 'Silver', 899.99),
   ('Coffee Maker', 'Black', 59.99),
   ('Throw Pillow', 'Blue', 14.99),
   ('Desk Lamp', 'White', 29.99),
   ('Backpack', 'Gray', 39.99),
   ('Bluetooth Speaker', 'Red', 49.99),
   ('Mouse Pad', 'Red', 9.99),
   ('Plant Pot', 'Green', 12.99),
   ('Notebook', 'Gray', 5.99),
   ('Tumbler', 'Blue', 7.99);
   ```
   
### API Documentation
The API documentation can be accessed using Swagger (https://<LOCALHOST:PORT>/swagger/index.html) 

![image](https://github.com/VictorLins/DotNetWebSearchAnalyticsAPI/assets/15841201/ffe9727f-fbfa-40fc-af82-1d44e4cd604e)

### Client Application
The client application was developed to provide an easy and quick way to create users in Microsoft Identity, fetch the JWT token and use it to test the API endpoints.
The client is a Windows Form application structured as per below:

![image](https://github.com/VictorLins/DotNetWebSearchAnalyticsAPI/assets/15841201/e77019f8-3957-40a4-88ed-baf0f4538e06)

1. API Health Check
2. API for retrieving a list of products
3. API for filtering products by color
4. API endpoint address for simulating API calls
5. JWT Token for request authentication
6. List of products returned from API calls
7. User creation in Microsoft Identity
8. User login in Microsoft Identity to obtain the token
9. Generated JWT Token for API authentication
