using AnimalDataAPI.Models;

namespace AnimalDataAPI.DataBase;

public interface IVisitDataBase
{
    int AddVisit(Visit visit);
    IEnumerable<Visit> GetVisitsForAnimal(int animalId);
}