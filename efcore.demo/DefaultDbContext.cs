using Microsoft.EntityFrameworkCore;

namespace efcore.demo;

public class DefaultDbContext : DbContext
{
    public DbSet<AppLoginLog> AppLoginLogs { get; set; }
    
    private readonly string connectionString = @"Server=127.0.0.1;port=3306;database=testdemo;user id=root;
    password=123456";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var version = ServerVersion.AutoDetect(connectionString);
        optionsBuilder.UseMySql(connectionString, version);
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.LogTo(System.Console.WriteLine).EnableSensitiveDataLogging();
    }
}
