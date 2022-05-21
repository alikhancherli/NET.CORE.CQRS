using AppService.Cqrs.Api.Contract;
using Domain.Cqrs.Api.Entities.User;

namespace Infra.Cqrs.Api.Implementation
{

    public class Repository : IRepository<Users>
    {
        private readonly List<Users> _context;

        public Repository()
        {
            _context = Users.UserInctance();
        }

        public async Task<bool> Add(Users entity)
        {
            _context.Add(entity);
            return await Task.FromResult(true);
        }

        public Task<Users?> Get(object id)
        {
            return Task.FromResult(_context.FirstOrDefault(a => a.Id == (int)id));
        }

        public async Task<List<Users>> Get()
        {
            return await Task.FromResult(_context);
        }
    }
}
