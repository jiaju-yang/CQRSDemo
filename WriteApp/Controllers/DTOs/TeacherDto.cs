namespace WriteApp.Controllers.DTOs;

public class TeacherDto : PersonDto
{
    public string TeacherNumber { get; set; } = default!;
    public DateOnly JoinedAt { get; set; }
    public AcademicAchievementDto AcademicAchievement { get; set; } = default!;
}
