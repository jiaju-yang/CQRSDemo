using Microsoft.AspNetCore.Mvc;
using WriteApp.Models;
using WriteApp.Controllers.DTOs;
using WriteApp.Mappers;

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

    [HttpPost(Name = "PostDepartment")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public DepartmentDto Post(DepartmentDto department)
    {
        Department model = department.ToModel();
        return new DepartmentDto();
    }

    [HttpGet(Name = "GetDepartment")]
    public IEnumerable<Department> Get()
    {
        return Enumerable.Empty<Department>();
    }
}
