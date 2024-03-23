using Clean.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clean.Services.Context;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }

    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
