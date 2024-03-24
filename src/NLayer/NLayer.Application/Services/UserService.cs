using NLayer.Context;
using NLayer.Domain;

namespace NLayer.Services;

public class UserService(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void Insert(User user)
    {
        _dbContext.Users.AddNH(user);
        _dbContext.SaveChanges();
    }
}
