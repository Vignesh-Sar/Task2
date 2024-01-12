using dataannotations.Models;
using Microsoft.EntityFrameworkCore;

namespace dataannotations.Datas;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    
    public DbSet<Data> Employeedetails{get; set;}
    public DbSet<Task1> ProjectStatus{get; set;}
    public DbSet<SignUp> Signups{get; set;}
}