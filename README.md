
# FlyingCargoProject

## Overview
This project is a three-tier architecture application built using **C# .NET**, with a **Windows Forms** GUI, **ASP.NET Web API** backend, and **Entity Framework Core** for database interactions with SQL Server.

### Technologies Used:
- **C#** (.NET 6 or later)
- **Windows Forms** for the UI
- **ASP.NET Web API**
- **Entity Framework Core** (for data access)
- **SQL Server**

---

## Getting Started

### Prerequisites

Before running the project, ensure you have the following installed:
- **Visual Studio 2022** or later
- **.NET 6 SDK** (or later)
- **SQL Server** (Express, Developer, or Full Edition)
- **Entity Framework Core Tools** (if using migrations)

---

## Steps to Clone and Set Up the Project

#### 1. Clone the Repository

Use the following commands to clone the repository and navigate into the project folder:

```bash
git clone https://github.com/TheDarko98/FlyingCargoProject.git
cd FlyingCargoProject
```

#### 2. Set Up the Database

Follow this to set up Database

##### Using the SQL Script

1. Open **SQL Server Management Studio (SSMS)**.
2. Create a new database called `FedEx` (or any other name of your choice).
3. Open the SQL script file `script.sql` (located in the repository).
4. Execute the script to create the tables and insert sample data into the database.

#### 3. Update the Connection String

You need to update the connection string to point to your local SQL Server instance in the `appsettings.json` file under the **FlyingCargoProject.Api** project.

Edit `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=FedEx;Trusted_Connection=True;"
  }
}
```

Make sure to replace `YOUR_SERVER_NAME` with the name of your SQL Server instance.

#### 4. Build the Solution

1. Open the solution in **Visual Studio 2022** by double-clicking `FlyingCargoProject.sln`.
2. **Restore NuGet packages** if needed by right-clicking on the solution and selecting `Restore NuGet Packages`.
3. Build the solution to ensure there are no build errors.

#### 5. Running the Application

You need to run both the **Web API** and the **Windows Forms GUI**:

##### Running the Web API

1. Set the **FlyingCargoProject.Api** as the startup project.
2. Run the project (it should be hosted at `https://localhost:7204` or whichever port you've configured).

##### Running the Windows Forms Application

1. Set the **FlyingCargoProject.Gui** project as the startup project.
2. Run the project to open the Windows Forms GUI.
3. The GUI will interact with the Web API to perform operations (e.g., load products, add products).
