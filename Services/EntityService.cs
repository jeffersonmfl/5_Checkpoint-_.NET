using MyCrudApp.Models;
using MyCrudApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCrudApp.Services
{
    public class EntityService
    {
        private readonly IEntityRepository _repository;

        public EntityService(IEntityRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Entity>> GetAllEntitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Entity> GetEntityByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddEntityAsync(Entity entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateEntityAsync(string id, Entity entity)
        {
            await _repository.UpdateAsync(id, entity);
        }

        public async Task DeleteEntityAsync(string id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
