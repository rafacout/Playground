using Microsoft.EntityFrameworkCore;

namespace Playground.EntityFramework;

public class NorthwindDb : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "/db/Northwind.db";
        string path = Path.Combine(Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        Console.WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);
    }
    
    
}