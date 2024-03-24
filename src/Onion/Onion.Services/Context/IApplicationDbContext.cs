using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;

namespace Onion.Services.Context;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<Order> Orders { get; }
    int SaveChanges();
}
