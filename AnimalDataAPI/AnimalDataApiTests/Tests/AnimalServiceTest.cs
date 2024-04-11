using System.Drawing;
using AnimalDataAPI.Models;
using AnimalDataAPI.Services;

namespace AnimalDataApiTests;

public class AnimalServiceTest
{
    [Fact]
    public void GetAnimals_Should_Return_List_Of_Animals()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var result = animalService.GetAnimals();
        
        Assert.NotNull(result);
    }

    [Fact]
    public void GetAnimalById_Should_Return_Animal_By_Given_Id()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var result = animalService.GetAnimalById(1);
        
        Assert.Equal(1,result.Id);
        Assert.Equal("Dog1", result.Name);
        Assert.Equal(10,result.Weight);
        Assert.Equal(AnimalCategory.DOG, result.AnimalCategory);
        Assert.Equal(Color.Brown, result.Color);
    }

    [Fact]
    public void AddAnimal_Should_Return_1_When_Animal_Is_Correct()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var animal = new Animal()
        {
            AnimalCategory = AnimalCategory.DOG,
            Color = Color.Brown,
            Id = 5,
            Name = "Dog1",
            Weight = 10
        };

        var result = animalService.AddAnimal(animal);
        
        Assert.Equal(1,result);
    }
    [Fact]
    public void AddAnimal_Should_Return_0_When_Animal_Is_Incorrect()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var animal = new Animal()
        {
            AnimalCategory = AnimalCategory.DOG,
            Color = Color.Brown,
            Id = 1,
            Name = "Dog1",
            Weight = 10
        };

        var result = animalService.AddAnimal(animal);
        
        Assert.Equal(0,result);
    }
    
    [Fact]
    public void UpdateAnimal_Should_Return_1()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var animal = new Animal()
        {
            AnimalCategory = AnimalCategory.DOG,
            Color = Color.Brown,
            Id = 1,
            Name = "DogUpdated",
            Weight = 100
        };

        var result = animalService.UpdateAnimal(animal);
        
        Assert.Equal(1,result);
    }

    [Fact]
    public void DeleteAnimal_Should_Return_1()
    {
        var animalService = new AnimalService(new TestAnimalDataBase());
        
        var result = animalService.RemoveAnimal(1);
        
        Assert.Equal(1,result);
    }
}