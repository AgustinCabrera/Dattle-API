using DattleAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DattleAPI.Infrastructure.Repositories
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAllAsync();
        Task<Animal> GetByIdAsync(int id);
        Task AddAsync(Animal animal);
        Task UpdateAsync(Animal animal);
        Task DeleteAsync(int id);
    }
}
