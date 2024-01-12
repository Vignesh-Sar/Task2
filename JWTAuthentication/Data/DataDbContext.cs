using System;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthentication.Models
{
    public class Datadbcontext:DbContext
    {
        public Datadbcontext(DbContextOptions<Datadbcontext> options):base (options)
        {

        }
        public DbSet<Register> Employees {get;set;}
    }
}