using System;
using System.Collections.Generic;

namespace WriteApp.Models;

public class Department
{
    public ulong Id { get; set; }
    public string Name { get; set; } = default!;
    public IEnumerable<Course> Courses { get; set; } = Enumerable.Empty<Course>();
}
