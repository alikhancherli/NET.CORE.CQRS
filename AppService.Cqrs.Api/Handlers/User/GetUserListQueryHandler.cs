using AppService.Cqrs.Api.Contract;
using AppService.Cqrs.Api.Dtos.User;
using AppService.Cqrs.Api.Queries.User;
using AutoMapper;
using Domain.Cqrs.Api.Entities.User;
using MediatR;

namespace AppService.Cqrs.Api.Handlers.User
{
    public sealed class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Users> _repository;

        public GetUserListQueryHandler(IMapper mapper, IRepository<Users> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<UserDto>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.Get();

            var mappedModel = _mapper.Map<List<UserDto>>(users);
            
            return await Task.FromResult(mappedModel);
        }
    }
}
