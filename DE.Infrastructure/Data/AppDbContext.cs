using System.Reflection;
using DE.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DE.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<RepairPart> RepairParts { get; set; } = null!;
    public DbSet<ReportRepairPart> ReportRepairParts { get; set; } = null!;
    public DbSet<Report> Reports { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Request> Requests { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=de;Username=postgres;Password=19392005");
}

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=de;Username=postgres;Password=19392005");

        return new AppDbContext(optionsBuilder.Options);
    }
}