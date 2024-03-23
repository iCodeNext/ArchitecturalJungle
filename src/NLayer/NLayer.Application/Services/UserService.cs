using NLayer.Context;
using NLayer.Domain;

namespace NLayer.Services;

public class UserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Insert(User user)
    {

        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}
