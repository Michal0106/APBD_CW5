using AnimalDataAPI.Models;
using AnimalDataAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AnimalDataAPI.EndPoints;

// public static class AnimalEndPoints
// {
//     private const string Route = "/api/animals";
//
//     public static void MapAnimalEndpoints(this WebApplication app)
//     {
//         app.MapGet(Route, () =>
//         {
//             var animals = AnimalService.GetAnimals();
//             return Results.Ok(animals);
//         });
//
//         app.MapGet($"{Route}/{{id}}", (int id) =>
//         {
//             var animal = AnimalService.GetAnimalById(id);
//             return Results.Ok(animal);
//         });
//
//         app.MapPost(Route, (Animal animal) =>
//         {
//             AnimalService.AddAnimal(animal);
//             return Results.Ok();
//         });
//
//         app.MapPut($"{Route}/{{id}}", (int id, Animal animal) =>
//         {
//             AnimalService.UpdateAnimal(id, animal);
//             return Results.Ok();
//         });
//
//         app.MapDelete($"{Route}/{{id}}", (int id) =>
//         {
//             AnimalService.RemoveAnimal(id);
//             return Results.Ok();
//         });
//     }
// }