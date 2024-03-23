using MediatR;

namespace Clean.Application.Users.Commands.CreateUser;

public record CreateUserCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}