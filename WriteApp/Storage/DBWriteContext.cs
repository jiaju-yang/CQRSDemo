using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using WriteApp.Models;

namespace WriteApp.Storage;
public class DBWriteContext : DbContext
{
    private readonly IConfiguration Configuration;
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    public DBWriteContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(Configuration["DBConnectionString"]);
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {

        builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

        base.ConfigureConventions(builder);

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Teacher>().OwnsOne(
            teacher => teacher.AcademicAchievement, ownedNavigationBuilder =>
            {
                ownedNavigationBuilder.ToJson();
            });
        builder.Entity<Course>()
            .HasMany(c => c.Teachers)
            .WithMany();
        builder.Entity<Course>()
            .HasMany(c => c.Students)
            .WithMany();
    }
}
