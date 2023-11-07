using AutoMapper;
using WriteApp.Controllers.DTOs;
using WriteApp.Models;

namespace WriteApp.Mappers;

public static class Mapper
{
    private static IMapper mapper = new MapperConfiguration(
        cfg =>
        {
            cfg.CreateMap<Department, DepartmentDto>().ReverseMap();
            cfg.CreateMap<Course, CourseDto>().ReverseMap();
        }).CreateMapper();

    public static DepartmentDto ToDto(this Department department)
    {
        return mapper.Map<DepartmentDto>(department);
    }
    public static Department ToModel(this DepartmentDto department)
    {
        return mapper.Map<Department>(department);
    }

    public static CourseDto ToDto(this Course course)
    {
        return mapper.Map<CourseDto>(course);
    }
    public static Course ToModel(this CourseDto course)
    {
        return mapper.Map<Course>(course);
    }
}
