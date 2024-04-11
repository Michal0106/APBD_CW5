using AnimalDataAPI.Models;
using AnimalDataAPI.Services;

namespace AnimalDataAPI.DataBase;

public class VisitDataBase : IVisitDataBase
{
    private static List<Visit> Visits = new()
    {
        new Visit {AnimalId = 1, DateTime = DateTime.Now.AddDays(-10), Description = "Regular checkup", Cost = 150},
        new Visit {AnimalId = 2, DateTime = DateTime.Now.AddDays(-15), Description = "Vaccination", Cost = 40},
        new Visit {AnimalId = 1, DateTime = DateTime.Now.AddDays(-20), Description = "Injury treatment", Cost = 60}
    };
    public int AddVisit(Visit visit)
    {
        try
        {
            Visits.Add(visit);
            return 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return 0;
        }
    }

    public IEnumerable<Visit> GetVisitsForAnimal(int animalId)
    {
        try
        {
            return Visits.FindAll(e => e.AnimalId == animalId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
}