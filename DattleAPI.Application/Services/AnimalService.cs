using DattleAPI.Application.Interfaces;
using DattleAPI.Domain.Entities;
using DattleAPI.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DattleAPI.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync()
        {
            return await _animalRepository.GetAllAsync();
        }

        public async Task<Animal> GetAnimalByIdAsync(int id)
        {
            return await _animalRepository.GetByIdAsync(id);
        }

        public async Task AddAnimalAsync(Animal animal)
        {
            await _animalRepository.AddAsync(animal);
        }

        public async Task UpdateAnimalAsync(Animal animal)  
        {
            await _animalRepository.UpdateAsync(animal);
        }

        public async Task DeleteAnimalAsync(int id)
        {
            await _animalRepository.DeleteAsync(id);
        }
    }
}
