using Microsoft.EntityFrameworkCore;
using NoArchitecture.Controllers;

namespace NoArchitecture.Services;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
