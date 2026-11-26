# MOHASEB

MOHASEB is a C# desktop ERP and accounting application built with Windows Forms. It is organized around accounting, sales, purchasing, inventory, and system-management modules, with Entity Framework 6 and SQL Server data access.

> Repository version: `MOHASEB_V1`

## Features

- Accounting and general-ledger management
- Accounts, account groups, cash, journals, currencies, and accounting periods
- Sales, customer requests, offers, sales bills, and returns
- Purchasing, supplier requests, purchase orders, bills, and returns
- Inventory control, stock transactions, item units and prices, stocking, and transfers
- Company, customer, vendor, employee, and user administration
- Entity Framework data model with SQL Server integration
- Windows Forms interface built with DevExpress components

## Technology Stack

- C# and .NET Framework 4.8
- Windows Forms
- Entity Framework 6
- SQL Server / SQL Server LocalDB-compatible database connections
- DevExpress WinForms controls
- Visual Studio 2019 or newer

## Requirements

- Windows 10 or Windows 11
- Visual Studio with **.NET desktop development** workload
- .NET Framework 4.8 Developer Pack
- SQL Server or SQL Server Express
- Valid DevExpress licenses/packages required by the project

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/MohanadTawfik/MOHASEB.git
   cd MOHASEB
   ```

2. Open `MOHASEB.sln` in Visual Studio.

3. Restore the NuGet packages and ensure the DevExpress assemblies referenced by `MOHASEB/MOHASEB.csproj` are available.

4. Configure the SQL Server connection in `MOHASEB/App.config`.

5. Build the solution and run the `MOHASEB` project.

## Database Configuration

The application uses an Entity Framework data model located in `MOHASEB/Model/MOHASEBModel.edmx`. Database connection settings are stored in `MOHASEB/App.config`.

Before running the application:

- Create or restore the MOHASEB SQL Server database.
- Update the Entity Framework and SQL Server connection strings for the target environment.
- Ensure the database login has the permissions needed to read and update application tables and execute stored procedures.

Do not commit real production credentials or connection secrets to source control.

## Project Structure

```text
MOHASEB/
├── MOHASEB.sln                 # Visual Studio solution
└── MOHASEB/
    ├── Classes/                # Application and database operations
    ├── Model/                  # Entity Framework entities and EDMX model
    ├── Views/
    │   ├── GUIs/               # Main application forms
    │   ├── Components/         # Reusable accounting and inventory controls
    │   └── PublicCompounent/   # Shared controls and dialogs
    ├── Resources/              # Icons and application resources
    ├── App.config              # Application and database configuration
    ├── MOHASEB.csproj          # Project configuration and dependencies
    └── Program.cs              # Application entry point
```

## Build

Open `MOHASEB.sln` in Visual Studio and select **Build > Build Solution**, or use the Visual Studio Developer Command Prompt:

```bash
msbuild MOHASEB.sln /p:Configuration=Release
```

## Main Modules

| Area | Examples |
|---|---|
| Accounts | Accounts, account groups, journals, cash, and periods |
| Sales | Customers, sales bills, offers, orders, and requests |
| Purchasing | Vendors, purchase requests, purchase orders, bills, and payments |
| Inventory | Items, stores, stock types, stocking, transfers, and settlement |
| System | Company, currencies, users, employees, permissions, and identity types |

## Contributing

Contributions are welcome.

1. Create a feature branch.
2. Make and test your changes.
3. Submit a pull request describing the update and its database or configuration impact.

## Author

Developed and maintained by [Mohanad Tawfik](https://github.com/MohanadTawfik).
