using AnimalDataAPI.Models;

namespace AnimalDataAPI.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimalById(int id);
    int AddAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int RemoveAnimal(int id);
}