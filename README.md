# TakePizza

## Aim of the project

TakePizza is a pizza ordering and management system with two types of users: **Clients** and **Administrators**.

Clients can:

* register and log in
* browse product categories and products
* place orders with one or more products
* choose a delivery address and payment type
* view their order history

Administrators can:

* manage product categories
* manage products
* view registered users
* review all orders
* filter orders by status and payment type

Orders can also be updated or deleted through the Web API.

The business logic is implemented in a shared **Service layer** and is used by two applications:

* a **Windows Forms desktop application**
* an **ASP.NET Core REST Web API**

The desktop application provides login and registration screens, together with separate menus for administrators and clients.

The Web API exposes the same core operations through HTTP and includes Swagger documentation.

## Technologies used

| Area               | Technology                                        |
| ------------------ | ------------------------------------------------- |
| Language / Runtime | C#, .NET 7                                        |
| Data Access        | Entity Framework Core 7.0.5                       |
| Database           | SQL Server LocalDB                                |
| Database Approach  | Code First, EF Core Migrations                    |
| Web API            | ASP.NET Core Web API                              |
| API Documentation  | Swagger / OpenAPI with Swashbuckle.AspNetCore 6.5 |
| Desktop UI         | Windows Forms                                     |
| IDE                | Visual Studio 2022                                |
| Solution           | `TakePizza.sln`                                   |

## Architecture

```text id="t4pw9s"
WinForm
   │
   ├──────────────┐
   │              │
   ▼              ▼
Service       WebApp
   │          REST API
   │
   ▼
DataManipulation
   │
   ▼
SQL Server
```

Both the Windows Forms application and the Web API use the shared `Service` layer.

The `Service` layer contains the business logic, while `DataManipulation` is responsible for database access through Entity Framework Core.

## Solution structure

```text id="jvx4sn"
TakePizza/
├── TakePizza.sln
│
├── DataManipulation/
│   ├── ApplicationDbContext.cs
│   ├── Configurations.cs
│   ├── Entities/
│   │   ├── User
│   │   ├── Order
│   │   ├── OrderDetails
│   │   ├── Product
│   │   └── Category
│   ├── Repositories/
│   └── Migrations/
│
├── Service/
│   └── Services/
│       ├── Category/
│       │   ├── CategoryService.cs
│       │   └── Models/
│       ├── Product/
│       │   ├── ProductService.cs
│       │   └── Models/
│       ├── Order/
│       │   ├── OrderService.cs
│       │   └── Models/
│       ├── User/
│       │   ├── UserService.cs
│       │   └── Models/
│       └── ErrorHandlerService.cs
│
├── WebApp/
│   ├── Program.cs
│   ├── Controllers/
│   │   ├── Category/
│   │   │   ├── CategoryController.cs
│   │   │   └── Models/
│   │   ├── Product/
│   │   │   ├── ProductController.cs
│   │   │   └── Models/
│   │   ├── Order/
│   │   │   ├── OrderController.cs
│   │   │   └── Models/
│   │   └── User/
│   │       ├── UserController.cs
│   │       └── Models/
│   ├── appsettings.json
│   └── Properties/
│       └── launchSettings.json
│
└── WinForm/
    ├── Program.cs
    ├── Common/
    ├── Forms/
    │   ├── LogInForm/
    │   ├── RegisterForm/
    │   ├── MainMenuAdmin/
    │   ├── MainMenuClient/
    │   ├── CategoryForm/
    │   ├── UserForm/
    │   ├── OrderFormAdmin/
    │   └── OrderFormClient/
    └── Resources/
```

## Projects
### WebApp

`WebApp` is an ASP.NET Core Web API.

It provides REST endpoints for:

* categories
* products
* orders
* users

Swagger is enabled to document and test the available API endpoints.

### WinForm

`WinForm` is the Windows Forms desktop application.

The application starts with the login screen and provides different functionality depending on the logged-in user type.

#### Administrator

Administrators can:

* manage categories
* manage products
* view users
* review orders
* filter orders by status and payment type

#### Client

Clients can:

* browse available products
* create orders
* select delivery information and payment type
* view their previous orders

## Running the project

### First use

1. Start the application.
2. On the login screen, select **Register**.
3. Create an account with the `Admin` user type.
4. Log in using the administrator account.
5. Add product categories and products.
6. Register another account with the `Client` user type.
7. Log in as the client and create an order.

## Running the Web API and desktop application together

In Visual Studio:

1. Right-click the solution.
2. Select **Configure Startup Projects...**
3. Choose **Multiple startup projects**.
4. Set both `WebApp` and `WinForm` to **Start**.
5. Run the solution.

This starts both the REST API and the Windows Forms application.
