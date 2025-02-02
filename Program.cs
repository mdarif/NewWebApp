/// <summary>
/// Entry point for the ASP.NET Core web application.
/// This minimal API application provides a REST API for managing todos.
/// </summary>

// Initialize the application builder with default configuration
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/// <summary>
/// In-memory storage for Todo items.
/// Note: This is temporary storage that will be cleared when the application restarts.
/// </summary>
var todos = new List<Todo>();

/// <summary>
/// POST endpoint to create a new todo item.
/// Route: /todos
/// </summary>
/// <remarks>
/// Sample request:
/// POST /todos
/// {
///     "id": 1,
///     "name": "Complete documentation",
///     "dueDate": "2024-02-20T10:00:00",
///     "isCompleted": false
/// }
/// </remarks>
/// <param name="task">The todo item to create</param>
/// <returns>Created response with the new todo item</returns>
app.MapPost("/todos", (Todo task) =>
{
    todos.Add(task);
    return TypedResults.Created("/todos/{id}", task);
});

// Starts the web application and begins listening for HTTP requests
app.Run();

/// <summary>
/// Represents a todo item in the application
/// </summary>
/// <param name="Id">Unique identifier for the todo item</param>
/// <param name="Name">Description of the todo item</param>
/// <param name="DueDate">Deadline for completing the todo item</param>
/// <param name="IsCompleted">Status indicating whether the todo item is completed</param>
public record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted);
