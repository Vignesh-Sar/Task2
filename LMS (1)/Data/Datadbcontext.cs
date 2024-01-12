using System;
using Microsoft.EntityFrameworkCore;

namespace LMS.Models
{
    public class Datadbcontext:DbContext
    {
        public Datadbcontext(DbContextOptions<Datadbcontext> options):base (options)
        {

        }
        public DbSet<Register> Employees {get;set;}
        public DbSet<Register> First_Value {get;set;}
         public DbSet<Entry> EmailValue {get;set;}

    }
}