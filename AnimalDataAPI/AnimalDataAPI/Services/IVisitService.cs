using AnimalDataAPI.Models;

namespace AnimalDataAPI.Services;

public interface IVisitService
{
    int AddVisit(Visit visit);
    IEnumerable<Visit> GetVisitsForAnimal(int animalId);
}