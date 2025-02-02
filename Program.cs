/// <summary>
/// Entry point for the ASP.NET Core web application.
/// This minimal API application serves a simple "Hello World!" response.
/// </summary>
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Maps the root URL ("/") to return a "Hello World!" string response
app.MapGet("/", () => "Hello World!");

// Starts the web application and begins listening for HTTP requests
app.Run();
