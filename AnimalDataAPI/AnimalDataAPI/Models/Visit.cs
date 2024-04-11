using System.ComponentModel.DataAnnotations;

namespace AnimalDataAPI.Models;

public class Visit
{
    [Required]
    public int AnimalId { get; set; }
    public DateTime DateTime { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
}