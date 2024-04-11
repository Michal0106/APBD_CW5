using AnimalDataAPI.DataBase;
using AnimalDataAPI.Models;

namespace AnimalDataAPI.Services;

public class VisitService : IVisitService
{
    private IVisitDataBase _visitDataBase;

    public VisitService(IVisitDataBase visitDataBase)
    {
        _visitDataBase = visitDataBase;
    }

    public int AddVisit(Visit visit)
    {
        return _visitDataBase.AddVisit(visit);
    }

    public IEnumerable<Visit> GetVisitsForAnimal(int animalId)
    {
        return _visitDataBase.GetVisitsForAnimal(animalId);
    }
}