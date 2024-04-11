using AnimalDataAPI.Controllers;
using AnimalDataAPI.DataBase;
using AnimalDataAPI.EndPoints;
using AnimalDataAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IAnimalDataBase, AnimalDataBase>();
builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddScoped<IVisitDataBase, VisitDataBase>();
builder.Services.AddScoped<IVisitService, VisitService>();

var app = builder.Build();

// app.MapAnimalEndpoints();
// app.MapVisitEndpoints();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

