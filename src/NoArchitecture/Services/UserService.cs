using NoArchitecture.Controllers;

namespace NoArchitecture.Services;

public class UserService(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void Insert(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}

