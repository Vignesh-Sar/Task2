using Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Datas;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    
    public DbSet<Login> Employeedetails{get; set;}
    public DbSet<Details> ProjectStatus{get; set;}
    public DbSet<data> Signups{get; set;}

   
}