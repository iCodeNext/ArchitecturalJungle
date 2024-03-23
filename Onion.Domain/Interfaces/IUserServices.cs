using Onion.Domain.Entities;

namespace Onion.Domain.Interfaces;
public interface IUserServices
{
    void Insert(User user);
    void Update(User user);
   //void Delete(User user);
    User FindById(int id);
}
