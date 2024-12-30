# Todo App

A simple console-based todo application built with .NET.

## Getting Started

### Prerequisites

- .NET SDK installed

### Running the Application

1. Clone the repository
2. Navigate to the project directory
3. Run the application:

   ```bash
   dotnet run
   ```

## Usage

The application provides a menu-driven interface with the following options:

1. **View Todos**
   - Displays all current todo items
   - Shows ID, title, description, completion status, and creation time

2. **Add Todo**
   - Add a new todo item
   - Requires a title (description is optional)

3. **Toggle Todo Status**
   - Mark a todo as completed or incomplete
   - Requires the todo ID

4. **Remove Todo**
   - Delete a todo item
   - Requires the todo ID

5. **Exit**
   - Quit the application

## Todo Item Format

Each todo item is displayed in the following format:

```
[ ] 1. Example Title - Example Description (Created: 2024-01-01 12:00)
```

- `[ ]` indicates incomplete, `[X]` indicates complete
- ID is shown before the title
- Creation timestamp is displayed in yyyy-MM-dd HH:mm format

## Notes

- Todos are stored in memory and will be cleared when the application exits
- Use the menu options to manage your todos
