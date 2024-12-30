namespace FormatExample.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }

    public Todo(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        IsCompleted = false;
        CreatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{(IsCompleted ? "X" : " ")}] {Id}. {Title} - {Description} (Created: {CreatedAt:yyyy-MM-dd HH:mm})";
    }
}