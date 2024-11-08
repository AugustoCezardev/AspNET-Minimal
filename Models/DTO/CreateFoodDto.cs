using System.ComponentModel.DataAnnotations;

namespace Minimal.API.Models.DTO;

public class CreateFoodDto
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }
}