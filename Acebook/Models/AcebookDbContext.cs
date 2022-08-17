namespace acebook.Models;
using Microsoft.EntityFrameworkCore;

public class AcebookDbContext : DbContext
{
    public DbSet<Post>? Posts { get; set; }
    public DbSet<User>? Users { get; set; }

    public string? DbPath { get; }

    public string? GetDatabaseName() {
      string? DatabaseNameArg = Environment.GetEnvironmentVariable("DATABASE_NAME");

      if( DatabaseNameArg == null)
      {
        System.Console.WriteLine(
          "DATABASE_NAME is null. Defaulting to test database."
        );
        return "acebook";
      }
      else
      {
        System.Console.WriteLine(
          "Connecting to " + DatabaseNameArg
        );
        return DatabaseNameArg;
      }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=acebook.postgres.database.azure.com;Username=Slava@acebook;Password='April2022!';Database=" + GetDatabaseName());
        // => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=1234;Database=" + GetDatabaseName());
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
          .Navigation(post => post.User)
          .AutoInclude();
    }
}
