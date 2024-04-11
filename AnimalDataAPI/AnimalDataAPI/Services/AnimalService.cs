using AnimalDataAPI.DataBase;
using AnimalDataAPI.Models;

namespace AnimalDataAPI.Services;

public class AnimalService : IAnimalService
{
    private IAnimalDataBase _animalDataBase;

    public AnimalService(IAnimalDataBase animalDataBase)
    {
        _animalDataBase = animalDataBase;
    }
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalDataBase.GetAnimals();
    }
    public Animal? GetAnimalById(int id)
    {
        return _animalDataBase.GetAnimalById(id);
    }
    public int AddAnimal(Animal animal)
    {
        return _animalDataBase.AddAnimal(animal);
    }
    public int UpdateAnimal(Animal animal)
    {
        return _animalDataBase.UpdateAnimal(animal);
    }
    public int RemoveAnimal(int id)
    {
        return _animalDataBase.RemoveAnimal(id);
    }
}