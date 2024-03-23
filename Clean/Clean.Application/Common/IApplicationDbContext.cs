using Clean.Domain;
using Clean.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clean.Services.Context;

public interface IApplicationDbContext
{
    IUserRepository Users { get; }

    int SaveChanges();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
