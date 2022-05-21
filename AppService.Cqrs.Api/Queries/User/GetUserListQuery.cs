using AppService.Cqrs.Api.Dtos.User;
using MediatR;

namespace AppService.Cqrs.Api.Queries.User
{
    public sealed class GetUserListQuery : IRequest<List<UserDto>>
    {
    }
}
