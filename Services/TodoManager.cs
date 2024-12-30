namespace FormatExample.Services
{
    using FormatExample.Models;

    public class TodoManager
    {
        private List<Todo> _todos;
        private int _nextId;

        public TodoManager()
        {
            _todos = new List<Todo>();
            _nextId = 1;
        }

        public void AddTodo(string title, string description)
        {
            var todo = new Todo(_nextId++, title, description);
            _todos.Add(todo);
        }

        public void ToggleTodoStatus(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                todo.IsCompleted = !todo.IsCompleted;
            }
        }

        public void RemoveTodo(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
        }

        public List<Todo> GetAllTodos()
        {
            return _todos;
        }

        public void DisplayTodos()
        {
            if (_todos.Count == 0)
            {
                Console.WriteLine("\nNo todos found. Add some todos to get started!");
                return;
            }

            Console.WriteLine("\nYour Todos:");
            Console.WriteLine("----------------------------------------");
            foreach (var todo in _todos)
            {
                Console.WriteLine(todo);
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}