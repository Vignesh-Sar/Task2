using System;
using Microsoft.EntityFrameworkCore;

namespace EmailApplication.Models
{
    public class Datadbcontext:DbContext
    {
        public Datadbcontext(DbContextOptions<Datadbcontext> options):base (options)
        {

        }
        public DbSet<Register>EmailData {get;set;}
    }
}