namespace WriteApp.Controllers.DTOs;

public class StudentDto : PersonDto
{
    public string StudentNumber { get; set; } = default!;
    public DateTime RegisteredAt { get; set; }
}
