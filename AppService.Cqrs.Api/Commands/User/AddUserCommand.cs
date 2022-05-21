using MediatR;

namespace AppService.Cqrs.Api.Commands.User
{
    public sealed record class AddUserCommand(
        string name,
        string family,
        string nationalCode) : IRequest<Task<bool>>;
}
