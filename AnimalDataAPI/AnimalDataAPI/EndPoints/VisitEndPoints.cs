using AnimalDataAPI.Models;
using AnimalDataAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AnimalDataAPI.EndPoints;

// public static class VisitEndPoints
// {
//     private const string Route = "/api/visits";
//
//     public static void MapVisitEndpoints(this WebApplication app)
//     {
//         app.MapGet($"{Route}/{{id}}", (int id) =>
//         {
//             var visit = VisitService.GetVisitsForAnimal(id);
//             return Results.Ok(visit);
//         });
//
//         app.MapPost(Route, (Visit visit) =>
//         {
//             VisitService.AddVisit(visit);
//             return Results.Ok();
//         });
//     }
// }