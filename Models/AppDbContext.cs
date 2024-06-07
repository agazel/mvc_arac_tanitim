// Data/AppDbContext.cs

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Araclar> Araclar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Data/araclar.db");
    }
}
