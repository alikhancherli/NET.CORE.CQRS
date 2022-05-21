using Domain.Cqrs.Api.Entities.Common;

namespace AppService.Cqrs.Api.Contract
{
    public interface IRepository<TEntity> where TEntity : class, IRootEntity
    {
        public Task<bool> Add(TEntity entity);

        public Task<TEntity?> Get(object id);

        public Task<List<TEntity>> Get();
    }
}
