using Microsoft.EntityFrameworkCore;
using NoArchitecture.Domain;

namespace NoArchitecture.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
