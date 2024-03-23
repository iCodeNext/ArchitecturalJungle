using Hexagonal.Application.Domain;
using Hexagonal.Application.Context;

namespace Hexagonal.Application.Services;

public class UserService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly ISmsProvider _smsProvider;

  

    public UserService(IApplicationDbContext dbContext, ISmsProvider smsProvider)
    {
        _dbContext = dbContext;
        _smsProvider = smsProvider;
    }

    public void Insert(User user)
    {
        _smsProvider.Send("");
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
    public void Update(User user) { }

    public void Delete(User user) { }

}
