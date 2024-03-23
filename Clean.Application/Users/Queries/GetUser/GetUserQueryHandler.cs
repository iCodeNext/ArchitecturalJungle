using Clean.Services.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Users.Queries.GetUser;

public class GetUserQueryHandler(IApplicationDbContext dbContext)
    : IRequestHandler<GetUserQuery, GetUserDto>
{
    private readonly IApplicationDbContext _dbContext = dbContext;

    public async Task<GetUserDto> Handle(GetUserQuery request,
                                         CancellationToken cancellationToken = default)
      => await _dbContext.Users
                   .Select(x => new GetUserDto(x.Id, x.Name))
                   .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
}