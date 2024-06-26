﻿using Onion.Domain.Entities;
using Onion.Services.Context;

namespace Onion.Services.Implementation;
public class UserServices(IApplicationDbContext dbContext)
{
    private readonly IApplicationDbContext _dbContext = dbContext;

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
