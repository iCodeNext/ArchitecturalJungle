using Hexagonal.Application.Domain;
using Hexagonal.Application.Context;

namespace Hexagonal.Application.Services;

public class UserService(IApplicationDbContext dbContext, ISmsProvider smsProvider)
{
    private readonly IApplicationDbContext _dbContext = dbContext;
    private readonly ISmsProvider _smsProvider = smsProvider;

    public void Insert(User user)
    {
        _smsProvider.Send("Message");
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}
