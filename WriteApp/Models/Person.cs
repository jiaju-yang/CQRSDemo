namespace WriteApp.Models;

public class Person
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;
    public DateOnly BirthDate { get; set; }
}
