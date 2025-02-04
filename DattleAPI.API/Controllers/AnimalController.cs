using DattleAPI.Application.Interfaces;
using DattleAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public async Task<IEnumerable<Animal>> GetAll()
    {
        return await _animalService.GetAllAnimalsAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Animal animal)
    {
        await _animalService.AddAnimalAsync(animal);
        return Ok();
    }
}
