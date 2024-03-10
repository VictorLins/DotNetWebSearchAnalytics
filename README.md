# Web Search Analytics Documentation

Welcome to the Web Search Analytics Documentation!
The aim of this project is to provide a web portal for users to search a **specific term** in Google and/or Bing and visualize how many times a **specific keyword** appeared in the results and also show its position/rank.

![Untitled](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/170ffe8b-3cbb-4bd1-9d73-e55d666f5c9e)


Microsoft Identity Manager, alongside Json Web Token (JWT), was utilized in this repository.
> [!NOTE]  
> Microsoft Identity and JWT are fully functional and available for integration into the frontend solution in upcoming releases.

This repository also includes unit tests and a Windows Forms client for convenient permission testing.

The following technologies and tools were utilized:

![Main Draft (2)](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/21bbea69-6763-4bdc-b477-9e7227079fb0)

## Table of Contents

1. [Web Search Analytics Documentation](#web-search-analytics-documentation)
2. [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Configuration](#configuration)
    - [Execution](#execution)
3. [Backend API Documentation](#backend-api-documentation)
4. [Security Client](#security-client)

## Getting Started

### Prerequisites

Before running the API, ensure you have the following installed:

- .NET 7 SDK: [Download here](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 22: [Download here](https://visualstudio.microsoft.com/vs/)
- SQL Server Express Edition [Download here](https://go.microsoft.com/fwlink/p/?linkid=2215158&clcid=0x809&culture=en-gb&country=gb)
- Node.js v20.11.0 [Download here](https://nodejs.org/en/download)
- Git [Download here](https://git-scm.com/downloads)

### Configuration

1. Clone the repository:

   ```bash
   git clone https://github.com/VictorLins/DotNetWebSearchAnalytics.git
   ```

2. Configure the Connection String in the API project "DotNetWebSearchAnalyticsAPI.API" (file: "appsettings.json")

   For test purposes, the following connection string was used, with the password intentionally visible

   ```bash
      "DefaultConnection": "Server=.\\SQLExpress;Database=SearchRankDb;User Id=sa;Password=SQLPassword123;MultipleActiveResultSets=True;TrustServerCertificate=True;"
   ```
   
4. Open Package Manager Console > Select project "DotNetSecureProductAPI" > run the following command: 
   ```bash
   update-database -context ApplicationDbContext
   ```

   The following tables should be created:
   
   ![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/caca0c23-04a8-4b84-8a35-4a2cebfa9960)

### Execution

1. Compile the API solution and **start** the project **DotNetWebSearchAnalyticsAPI.Api**

   ![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/48fe786d-6684-41e1-86f5-9b1b5659e14a)

3. Compile the WebPortal solution (Please note that Node.js is required and this process may take a few minutes).
   
> [!WARNING]  
> For any problem in this step, please go to the folder "**DotNetWebSearchAnalyticsWebPortal\dotnetwebsearchanalyticswebportal.client**" → Delete the folder "**node_modules**" → Open CMD → Execute the command "**npm install**"
   
5. Run the project
   
![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/2f009260-2cfd-4ff7-a4e5-6be8ad8d1550)

### Backend API Documentation
The API documentation can be accessed using Swagger (https://<LOCALHOST:PORT>/swagger/index.html) 

![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/bf21969c-ed20-4373-90ff-eafd6690c8cb)

### Security Client
A client application was developed to provide an easy and quick way to create users in Microsoft Identity, fetch the JWT token and use it to test the API endpoints. To use this tool, you just need to create a user, and then perform the login operation, at the end of this process a Token will be generated.

Although this feature is fully operational, it has not yet been plugged in the frontend solution.

Please note that the user **admin@example.com** with the password **Password@123** was already created for testing purposes.

![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/61ffdde3-5997-430f-9c5f-993cedadb04d)

The client is a Windows Form application structured as per below:

![image](https://github.com/VictorLins/DotNetWebSearchAnalytics/assets/15841201/3cc2e569-c1c2-406b-9e8e-3d228fef85a3)

