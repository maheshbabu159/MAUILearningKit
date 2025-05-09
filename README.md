# MAUILearningKit

MAUILearningKit has the implementation to integrate api's developed in .NET ASP and show case the mobile development using .NET MAUI.

![Demo](demo.gif)


## Features

- Show customers
- Show orders
- Bar code scanner 
- Socket integration

## Screenshots

<p align="center">

<img src="search.png" alt="" width="350" height="600">
<img src="search_results.png" alt="" width="350" height="600">
<img src="details.png" alt="" width="350" height="600">

</p>
## Requirements

- VSCode
- .NET SDK
- Xcode 12.0 or later.
- iOS 14.0 or later.
- VS Code

## Setup
1. **SQL Server on Mac**:
    
        $ docker pull mcr.microsoft.com/azure-sql-edge
        
        $ docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=reallyStrongPwd123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
        
        $ docker container ls

        # To stop use following command
        $ docker container stop container_id

2. **Create project**: 

        $ cd MAUILearningKit
        $ dotnet add package Microsoft.EntityFrameworkCore.InMemory

5. **Build**:

        $ dotnet run --framework net9.0-maccatalyst

5. **Packages**:

        $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        $ dotnet add package Microsoft.EntityFrameworkCore.Tools
        # Create models for tables
        $ dotnet ef dbcontext scaffold \
                        "Server=localhost,1433;Database=tempdb;User Id=sa;Password=Narasimha@2025;Encrypt=False;TrustServerCertificate=True;" \
                        Microsoft.EntityFrameworkCore.SqlServer \
                        -o Models -f


        $ dotnet aspnet-codegenerator controller \
                        -name CustomersController \
                        -m Customer \
                        -dc TempdbContext \
                        -outDir Controllers \
                        -api \
                        -async

## Project Structure

### Main Components:

## How to Run the App

1. Clone the repository:

2. Open the project in Xcode.

3. Build and run the app on a simulator or physical device.


## API

The app fetches photos from the public Flickr API. The request URL is:

### Example API Response:


## Unit Tests


### To run the tests:



## Accessibility

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.