using Microsoft.EntityFrameworkCore;
using Task1.Model;


namespace Task1.Database;


public class DbSystem :DbContext
{
    public DbSystem(DbContextOptions<DbSystem> options) : base(options)
    {

    }

    public DbSet<Course> courses { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }


}
