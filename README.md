# Todo List MVC Application

This is a simple ASP.NET Core MVC application for managing a to-do list. It allows users to create, view, edit, and delete tasks.

## Features

*   **Create new tasks:** Add new to-do items with a title and description.
*   **View tasks:** See a list of all to-do items.
*   **View task details:** See the details of a specific to-do item.
*   **Edit tasks:** Modify the title, description, and completion status of existing tasks.
*   **Delete tasks:** Remove tasks from the list.
*   **Mark tasks as done/not done:** Toggle the completion status of a task.

## How to Run the Project

1.  **Prerequisites:**
    *   [.NET SDK](https://dotnet.microsoft.com/download) (version 9.0 or later recommended, based on the project files)
2.  **Clone the repository:**
    ```bash
    git clone <repository-url>
    cd <repository-directory>
    ```
3.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```
4.  **Run the application:**
    ```bash
    dotnet run
    ```
    The application will typically be available at `https://localhost:5001` or `http://localhost:5000`. Check the console output for the exact URL.

## Project Structure

*   **`Controllers/`**: Contains the C# controller classes that handle incoming HTTP requests and orchestrate responses.
    *   `HomeController.cs`: Handles requests for the home page.
    *   `TodoController.cs`: Handles CRUD (Create, Read, Update, Delete) operations for to-do items.
*   **`Models/`**: Contains the C# model classes that represent the data and business logic of the application.
    *   `TodoItem.cs`: Defines the structure of a to-do item.
    *   `TodoFormViewModel.cs`: A view model used for the create/edit forms, potentially including things like page titles or select lists.
    *   `ErrorViewModel.cs`: Used for displaying error information.
*   **`Views/`**: Contains the Razor view files (`.cshtml`) that define the user interface.
    *   `Home/`: Views related to the `HomeController`.
    *   `Todo/`: Views related to the `TodoController` (e.g., displaying the list of to-dos, forms for creating/editing to-dos).
    *   `Shared/`: Views shared across multiple controllers (e.g., layouts, error pages).
*   **`wwwroot/`**: Contains static assets like CSS, JavaScript, and images.
*   **`Program.cs`**: The main entry point of the application, responsible for configuring services and the HTTP request pipeline.
*   **`TodoMvcApp.csproj`**: The project file, containing project metadata, dependencies, and build settings.

## Data Storage

**Note:** This project uses an in-memory list (`List<TodoItem>`) in the `TodoController` to store to-do items. This means that any data added or modified will be lost when the application stops. This is for demonstration purposes only.

## Future Enhancements

*   **Database Integration:** Replace the in-memory list with a persistent database (e.g., SQL Server, PostgreSQL, SQLite using Entity Framework Core).
*   **User Authentication and Authorization:** Implement user accounts to allow multiple users to manage their own to-do lists.
*   **API Endpoints:** Add a Web API for managing to-do items, allowing integration with other applications or a JavaScript frontend.
*   **Input Validation:** Enhance client-side and server-side validation.
*   **Unit and Integration Tests:** Add comprehensive tests to ensure code quality and reliability.
*   **User Interface Improvements:** Enhance the look and feel with a more modern UI framework or styling.
