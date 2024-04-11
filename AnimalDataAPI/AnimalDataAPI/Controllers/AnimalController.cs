using AnimalDataAPI.Models;
using AnimalDataAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AnimalDataAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;
    
    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }

    [HttpGet("/{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimalById(id);
        if (animal == null)
        {
              return NotFound(animal);
        }
        return Ok(animal); 
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animalService.AddAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        _animalService.UpdateAnimal(animal);
        return NoContent();
    }

    [HttpDelete("/{id:int}")]
    public IActionResult RemoveAnimal(int id)
    {
        _animalService.RemoveAnimal(id);
        return NoContent();
    }
}