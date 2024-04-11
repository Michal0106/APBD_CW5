using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AnimalDataAPI.Models;

public class Animal
{
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public AnimalCategory AnimalCategory { get; set; }
    public int Weight { get; set; }
    public Color Color { get; set; }
}