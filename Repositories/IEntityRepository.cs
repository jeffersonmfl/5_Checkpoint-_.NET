using MyCrudApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCrudApp.Repositories
{
    public interface IEntityRepository
    {
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<Entity> GetByIdAsync(string id);
        Task AddAsync(Entity entity);
        Task UpdateAsync(string id, Entity entity);
        Task DeleteAsync(string id);
    }
}
