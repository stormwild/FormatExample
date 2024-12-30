using FormatExample.Services;

namespace FormatExample
{
    class Program
    {
        static void Main()
        {
            var todoManager = new TodoManager();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Todo App");
                Console.WriteLine("--------");
                Console.WriteLine("1. View Todos");
                Console.WriteLine("2. Add Todo");
                Console.WriteLine("3. Toggle Todo Status");
                Console.WriteLine("4. Remove Todo");
                Console.WriteLine("5. Exit");
                Console.Write("\nSelect an option: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        todoManager.DisplayTodos();
                        break;
                    case "2":
                        Console.Write("Enter title: ");
                        var title = Console.ReadLine();
                        Console.Write("Enter description: ");
                        var description = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(title))
                        {
                            todoManager.AddTodo(title, description ?? string.Empty);
                            Console.WriteLine("\nTodo added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nTitle cannot be empty!");
                        }
                        break;
                    case "3":
                        Console.Write("Enter todo ID to toggle: ");
                        if (int.TryParse(Console.ReadLine(), out var toggleId))
                        {
                            todoManager.ToggleTodoStatus(toggleId);
                            Console.WriteLine("\nTodo status toggled!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid ID!");
                        }
                        break;
                    case "4":
                        Console.Write("Enter todo ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out var removeId))
                        {
                            todoManager.RemoveTodo(removeId);
                            Console.WriteLine("\nTodo removed!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid ID!");
                        }
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option!");
                        break;
                }

                if (running && input != "5")
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nThank you for using the Todo App!");
        }
    }
}
