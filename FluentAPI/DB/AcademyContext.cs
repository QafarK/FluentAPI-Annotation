using FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.DB;

internal class AcademyContext : DbContext
{ 
    public AcademyContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Academy;Integrated Security=SSPI;").UseAllCheckConstraints();
    }
}
