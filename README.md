<h1 align="center">
  <p align="center">CardDealers Proyect</p>
</h1>

![Imagen ilustrativa](https://github.com/guido-sanz/guido-sanz-parcial1/blob/main/img/ColDualSptNoRack.jpg)

<p align="left">
   <img src="https://img.shields.io/badge/STATUS-Development-green">
   <img src="https://img.shields.io/badge/LANGUAJE-.NET-blueviolet">
   <img src="https://img.shields.io/badge/VERSION-1.0-blue">
</p>

<h2>Project description</h2>
<p>The existing project is a management system that allows managing motorcycle agencies, controlling inventories and supervising motorcycles in stock. It provides a platform where users can create agencies, add and update motorcycles in their exclusive inventories, as well as track sales and generate related reports. The objective is to optimize the management of motorcycle agencies, improve efficiency in inventory control and provide tools for monitoring and analyzing relevant data.</p>

## :hammer:Funcionalidades del proyecto

- `Functionality 1`: Agency administration
     - Creation of agencies with basic information (name, location, contact, etc.)
     - Editing and updating details of existing agencies.
     - Assignment of users and permissions to each agency.
      
- `Functionality 2`: Inventory management
     - Creation of exclusive inventories for each agency.
     - Editing and updating details of existing agencies.
     - Added motorcycles to the inventory with specific details (make, model, year, features, prices, etc.).
     - Updating and deleting existing motorcycles in the inventory.
     - Monitoring the availability of motorcycles in stock.

- `Functionality 3`: Sales control
     - Record of motorcycle sales made by each agency.
     - Monitoring of motorcycles sold and their current status.
     - Generation of sales reports, including data such as agency, motorcycle sold, date and price.

- 'Business functionality'
     - When loading a new motorcycle to the inventory, if this motorcycle already exists it is added to the quantity in stock.
     - When entering the inventory of an office, the total amount of money in stock and the number of motorcycles in stock are shown.
 
## 📁 Project access

- `How to access the project`:
    - [Link to github repository](https://github.com/Tanqueta88/CarDealers_Proyect.git)

## 🛠️ Open and run the project

- `How to run the project`:
     - 1st install the dependencies to use ORM
         - "dotnet tool install --global dotnet-aspnet-codegenerator"
         - "dotnet tool install --global dotnet-ef"
         - "dotnet add package Microsoft.EntityFrameworkCore.Design"
         - "dotnet add package Microsoft.EntityFrameworkCore.SQLite"
         - "dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design"
         - "dotnet add package Microsoft.EntityFrameworkCore.Tools"
     - 2° Run the "dotnet build" command
     - 3rd execute the "dotnet run" command to start the application

## ✔:Technologies used
   - Microsoft .NET
   -HTML
   - JAVASCRIPT
