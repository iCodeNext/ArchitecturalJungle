using Microsoft.EntityFrameworkCore;
using NLayer.Domain;

namespace NLayer.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
