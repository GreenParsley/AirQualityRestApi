using Microsoft.EntityFrameworkCore;

namespace AirQualityAPI.Entities;

public class AirQualityDbContext : DbContext
{
    public DbSet<Measures> Measures { get; set; } = null!;
    public DbSet<Positions> Positions { get; set; } = null!;
    public DbSet<Trips> Trips { get; set; } = null!;

    public AirQualityDbContext(DbContextOptions<AirQualityDbContext> options) : base(options)
    {
        _ = options ?? throw new ArgumentNullException(nameof(options));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        _ = optionsBuilder ?? throw new ArgumentNullException(nameof(optionsBuilder));
        optionsBuilder.UseLoggerFactory(new LoggerFactory());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
