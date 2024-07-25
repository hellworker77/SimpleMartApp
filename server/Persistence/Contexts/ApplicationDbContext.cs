using System.Reflection;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<User,
    IdentityRole<Guid>,
    Guid,
    IdentityUserClaim<Guid>,
    IdentityUserRole<Guid>,
    IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>,
    IdentityUserToken<Guid>>(options)
{
    public DbSet<Category> Categories => Set<Category>();
    
    public DbSet<CategoryProduct> CategoryProducts => Set<CategoryProduct>();
    
    public DbSet<Order> Orders => Set<Order>();
    
    public DbSet<OrderProduct> OrderProducts => Set<OrderProduct>();
    
    public DbSet<Product> Products => Set<Product>();
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}