using Microsoft.AspNetCore.Mvc;
using WriteApp.Models;

namespace WriteApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly ILogger<DepartmentController> Logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        Logger = logger;
    }

    [HttpGet(Name = "GetDepartment")]
    public IEnumerable<Department> Get()
    {
        return Enumerable.Empty<Department>();
    }
}
