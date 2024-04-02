# Students_API-CRUD 👨‍🎓

## Description 🔶

This is an API to demonstrate the simple and easy use of technologies in C# language with ASP.NET. With the intention of learning, I built this API to understand the general functioning of Entity Framework and everything that involves the creation and manipulation of Database through it. This system was built using the SQLite database.

Below are some instructions.

## Index

- [Installation](#Installation)
- [Usage](#Usage)
- [License](#License)

## Installation <a name="Installation"></a> ⚙

The project template chosen at the time of creating the solution was the following:

![image](https://github.com/Dablio-0/Students_API-CRUD/assets/126510148/e7436908-33e3-45af-9e43-1029baddca06)

To run this project, you must add the following packages with the NuGet package manager:

![image](https://github.com/Dablio-0/Students_API-CRUD/assets/126510148/52d52e7d-faa7-441d-90c8-265dc24d1c71)

You can use the NuGet graphical interface if you are in Visual Studio, or install via CLI, with the following commands:

```powershell
# if you want to add the version just add --version <version> 

# Microsoft EntityFramworkCore 
dotnet add package Microsoft.EntityFrameworkCore 

# Microsoft EntityFrameworkCore Tools
dotnet add package Microsoft.EntityFrameworkCore.Tools

# Microsoft EntityFrameworkCore SQlite
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```
## Usage <a name="Usage"></a>✅

- Routes Screen for HTTP Requests
![image](https://github.com/Dablio-0/Students_API-CRUD/assets/126510148/89834622-24c1-4e42-af2e-4c281e97bc18)

The screen above is where you will find the routes and will be able to actually use the system, inserting and manipulating information in the database.

Each request option is opened when you expand the option, where if necessary you will pass parameters in the route, to later obtain the JSONs of response for each request made.

## License <a name="License"></a>

This project is using the [MIT license](LICENSE), so feel free to use it.
### Thanks for the attention! =)
