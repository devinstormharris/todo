namespace Todo.Utilities.Models;

public class UserTask
{
    public DateTime DateCreated { get; set; }

    public string Title { get; set; }

    public string? Summary { get; set; }
}