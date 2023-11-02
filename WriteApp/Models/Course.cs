using System.Collections.Generic;

namespace WriteApp.Models;

public class Course
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;

    public IEnumerable<Teacher> Teachers { get; set; } = Enumerable.Empty<Teacher>();
    public IEnumerable<Student> Students { get; set; } = Enumerable.Empty<Student>();
}
