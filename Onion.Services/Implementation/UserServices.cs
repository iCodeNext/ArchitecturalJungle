using Onion.Domain.Entities;
using Onion.Domain.Interfaces;
using Onion.Services.Context;

namespace Onion.Services.Implementation;
public class UserServices : IUserServices
{
    private readonly IApplicationDbContext _dbContext;

    public UserServices(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //public void Delete(User user)
    //{
    //    _dbContext.Users.Remove(user);
    //}

    public User FindById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(User user)
    {
        _dbContext.Users.Add(user);
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }
}
