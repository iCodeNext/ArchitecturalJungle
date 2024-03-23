using Clean.Domain.Entities;
using Clean.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace Clean.Infrastructure.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options), IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
}
