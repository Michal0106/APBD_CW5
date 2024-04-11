using AnimalDataAPI.Models;

namespace AnimalDataAPI.DataBase;

public interface IAnimalDataBase
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimalById(int id);
    int AddAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int RemoveAnimal(int id);
}