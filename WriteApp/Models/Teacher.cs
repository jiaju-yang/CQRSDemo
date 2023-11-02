namespace WriteApp.Models;

public class Teacher : Person
{
    public string TeacherNumber { get; set; } = default!;
    public DateOnly JoinedAt { get; set; }
    public AcademicAchievement AcademicAchievement { get; set; } = default!;
}
