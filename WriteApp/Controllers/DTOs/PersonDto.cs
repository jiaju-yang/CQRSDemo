namespace WriteApp.Controllers.DTOs;

public class PersonDto
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;
    public DateOnly BirthDate { get; set; }
}
