using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Minimal.API.Entities;

public class Food
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = [];

    [SetsRequiredMembers]
    public Food(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Food()
    {

    }
}

