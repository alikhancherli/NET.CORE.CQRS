using AppService.Cqrs.Api.Commands.User;
using AppService.Cqrs.Api.Contract;
using Domain.Cqrs.Api.Entities.User;
using MediatR;

namespace AppService.Cqrs.Api.Handlers.User
{
    public sealed class AddUserCommandHandler : IRequestHandler<AddUserCommand, Task<bool>>
    {
        private readonly IRepository<Users> _repository;

        public AddUserCommandHandler(IRepository<Users> repository)
        {
            _repository = repository;
        }

        public async Task<Task<bool>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            //ex : validation

            var user = Users.New(
                request.name,
                request.family,
                request.nationalCode);

            await _repository.Add(user);

            return Task.FromResult(true);
        }
    }
}
