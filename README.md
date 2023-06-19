⭐ Don't forget to star this app as it's using latest tools and technology ⭐

This is an open-source repo. If you would like to add something or correct a mistake, please open a PR.

# Pro.CQRSAndMediatRExample
Example to showcase two primary software architecture patterns: CQRS and the Mediator pattern. To understand the implemented architecture please read documentation about 
[Implement the microservice application layer using the Web API.](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-application-layer-implementation-web-api)

## Setting up an ASP.NET Core API with MediatR
The [Asp.Net Core Web Application](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-7.0) in this example simply separates the query and command models. 
In order to execute the HTTP requests via Swagger, you need to update the default dbconnection string in appsettings.json. Then build and run the project.

## Dependencies
Install a couple of packages via the Package Manager Console.
First, the **MediatR** package:
**PM> install-package MediatR**
You might need to install the **MediatR.Extensions.Microsoft.DependencyInjection package**, but that is not required from MediatR v12.

Hope you enjoyed this example and have a good foundation on CQRS and MediatR.

Happy coding!
