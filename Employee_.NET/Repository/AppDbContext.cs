using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Repository;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(/*@"Put your Database Connection String"*/); //Update your connection string here keep @ before the string
        }
    }
    public DbSet<Employee> Employees { get; set; }

}
