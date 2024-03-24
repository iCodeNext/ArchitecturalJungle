using Onion.Domain.Entities;
using Onion.Services.Context;

namespace Onion.Services.Implementation;
public class OrderServices(IApplicationDbContext dbContext)
{
    private readonly IApplicationDbContext _dbContext = dbContext;

    public void Insert(Order order)
    {
        _dbContext.Order.Add(order);
    }
}
