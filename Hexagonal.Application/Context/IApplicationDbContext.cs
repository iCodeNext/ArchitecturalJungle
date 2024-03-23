using Hexagonal.Application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Application.Context;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }

    int SaveChanges();
}
