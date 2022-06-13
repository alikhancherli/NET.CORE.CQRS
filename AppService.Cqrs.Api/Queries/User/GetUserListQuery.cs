using AppService.Cqrs.Api.Dtos.User;
using MediatR;

namespace AppService.Cqrs.Api.Queries.User
{
    public record GetUserListQuery() : IRequest<List<UserDto>>;
}
