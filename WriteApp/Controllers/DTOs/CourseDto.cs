using System.Collections.Generic;

namespace WriteApp.Controllers.DTOs;

public class CourseDto
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;

    public IEnumerable<TeacherDto> Teachers { get; set; } = Enumerable.Empty<TeacherDto>();
    public IEnumerable<StudentDto> Students { get; set; } = Enumerable.Empty<StudentDto>();
}
