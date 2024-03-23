using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using Onion.Services.Context;

namespace Onion.Infrastructure.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options) , IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
}
