namespace Hexagonal.Application.Context;
public interface ISmsProvider
{
    void Send(string message);
}
