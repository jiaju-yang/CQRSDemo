namespace WriteApp.Models;

public class Student : Person
{
    public string StudentNumber { get; set; } = default!;
    public DateTime RegisteredAt { get; set; }
}
