using Microsoft.EntityFrameworkCore;
using Hexagonal.Application.Domain;
using Hexagonal.Application.Context;

namespace Hexagonal.DataAccess.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options) , IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
}
