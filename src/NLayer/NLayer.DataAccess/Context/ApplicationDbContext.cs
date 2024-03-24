using Microsoft.EntityFrameworkCore;
using NLayer.Domain;

namespace NLayer.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DBNHSET<User> Users { get; set; }
}
