using Onion.Domain.Entities;
using Onion.Services.Implementation;

namespace Onion.ApplicationService;
public class OrderManagement(UserServices userServices,
    OrderServices orderServices) : IOrderManagement
{
    public void AddOrder(int id, string name)
    {
        var user = userServices.FindById(id);
        if (user is not null)
        {
            orderServices.Insert(new Order
            {
                Amount = 1000,
                Name = name
            });
        }
    }
}
