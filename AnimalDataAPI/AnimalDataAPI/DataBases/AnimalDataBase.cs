using System.Drawing;
using AnimalDataAPI.Models;
using Microsoft.Extensions.FileProviders;

namespace AnimalDataAPI.DataBase;

public class AnimalDataBase : IAnimalDataBase
{
    private static List<Animal> Animals = new()
    {
        new Animal(){AnimalCategory = AnimalCategory.DOG, Color = Color.Brown,Id = 1,Name = "Dog1",Weight = 10},
        new Animal(){AnimalCategory = AnimalCategory.CAT, Color = Color.Beige,Id = 2,Name = "Cat1",Weight = 4},
        new Animal(){AnimalCategory = AnimalCategory.DOG, Color = Color.Chocolate,Id = 3,Name = "Dog2",Weight = 15},
        new Animal(){AnimalCategory = AnimalCategory.CAT, Color = Color.Beige,Id = 4,Name = "Cat2",Weight = 7},
    };

    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }

    public Animal GetAnimalById(int id)
    {
        return Animals.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException();
    }

    public int AddAnimal(Animal animal)
    {
        if (Animals.Any(a => a.Id == animal.Id)) return 0;
        
        Animals.Add(animal);
        return 1;
    }

    public int UpdateAnimal(Animal animal)
    {
        var existingAnimal = Animals.FirstOrDefault(e => e.Id == animal.Id);
        if (existingAnimal != null)
        {
            existingAnimal.Id = animal.Id;
            existingAnimal.Name = animal.Name;
            existingAnimal.AnimalCategory = animal.AnimalCategory;
            existingAnimal.Weight = animal.Weight;
            existingAnimal.Color = animal.Color;
            return 1; 
        }
        throw new KeyNotFoundException($"Animal with ID {animal.Id} not found.");
    }

    public int RemoveAnimal(int id)
    {
        var animal = Animals.FirstOrDefault(e => e.Id == id);
        Animals.Remove(animal ?? throw new KeyNotFoundException($"Animal with ID {id} not found."));
        return 1;
    }
}