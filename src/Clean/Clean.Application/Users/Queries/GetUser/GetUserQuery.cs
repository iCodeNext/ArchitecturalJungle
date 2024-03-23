using MediatR;

namespace Clean.Application.Users.Queries.GetUser;

public record GetUserQuery(int Id) : IRequest<GetUserDto>;