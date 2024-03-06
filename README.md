# StockTrack

## Project Description
StockTrack is an Inventory Management System designed to help stores efficiently manage their inventory. Built using WCF (Windows Communication Foundation) and .NET Framework, StockTrack provides essential functionalities for product management, transaction tracking, and authentication. It utilizes Entity Framework Core for database connectivity, ensuring seamless integration with various database providers.

## Prerequisites
- .NET Framework
- Windows Communication Foundation (WCF)
- Visual Studio (or any compatible IDE)
- Entity Framework Core

## Installation
1. Clone or download the project repository from [GitHub](https://github.com/Nilesh9106/stocktrack).
2. Open the project in Visual Studio.
3. Open Package Manager Console by going to `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.
4. Run the following commands in the Package Manager Console:

```bash
# Add EF Core tools if not already installed
Install-Package Microsoft.EntityFrameworkCore.Tools

# Create a migration
Add-Migration InitialCreate

# Update the database with the migration
Update-Database
```
5. These commands will create the initial migration for the database schema based on your EF Core DbContext and apply it to your database.
6. Configure the database connection string in `appsettings.json` or `web.config ` file as necessary.
7. Build the solution to ensure all dependencies are resolved and the code compiles successfully.
8. Run the application.
## Usage
1. **Account Creation**: Stores can create an account by providing required details.
2. **Product Management**: Stores can add, view, edit, and delete products in their inventory.
3. **Transaction Management**: Stores can perform transactions such as selling or buying products. They can view all transactions or transactions related to a specific product.
4. **Authentication**: Secure authentication ensures only authorized users can access the system.
## Features
- Account creation and authentication for secure access.
- CRUD operations for managing products.
- Transaction tracking for buying and selling products.
- View transaction history for individual products or all products.
