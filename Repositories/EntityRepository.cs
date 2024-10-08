using MongoDB.Driver;
using MyCrudApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCrudApp.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly IMongoCollection<Entity> _entities;

        public EntityRepository(IMongoClient client)
        {
            var database = client.GetDatabase("MyDatabase");
            _entities = database.GetCollection<Entity>("Entities");
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _entities.Find(_ => true).ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(string id)
        {
            return await _entities.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Entity entity)
        {
            await _entities.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(string id, Entity entity)
        {
            await _entities.ReplaceOneAsync(e => e.Id == id, entity);
        }

        public async Task DeleteAsync(string id)
        {
            await _entities.DeleteOneAsync(e => e.Id == id);
        }
    }
}
