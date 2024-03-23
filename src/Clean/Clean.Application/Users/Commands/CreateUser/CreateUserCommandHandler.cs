using Clean.Domain.Entities;
using Clean.Services.Context;
using MediatR;

namespace Clean.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IApplicationDbContext dbContext)
    : IRequestHandler<CreateUserCommand, int>
{
    private readonly IApplicationDbContext _dbContext = dbContext;

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken = default)
    {
        var user = new User
        {
            Name = request.FirstName,
        };
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return user.Id;
    }
}