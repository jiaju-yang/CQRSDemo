using System;
using System.Collections.Generic;

namespace WriteApp.Controllers.DTOs;

public class DepartmentDto
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;
    public IEnumerable<CourseDto> Courses { get; set; } = Enumerable.Empty<CourseDto>();
}
