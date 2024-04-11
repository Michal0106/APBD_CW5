using AnimalDataAPI.Models;
using AnimalDataAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalDataAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VisitController : ControllerBase
{
    private IVisitService _visitService;

    public VisitController(IVisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpGet("animal/{id}")]
    public IActionResult GetVisitsForAnimal(int id)
    {
        var visits = _visitService.GetVisitsForAnimal(id);
        if (visits is null)
        {
            return NotFound(visits);
        }
        return Ok(visits); 
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        _visitService.AddVisit(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}