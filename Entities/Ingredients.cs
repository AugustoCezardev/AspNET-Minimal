using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Minimal.API.Entities;

public class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    public ICollection<Food> Foods { get; set; } = [];

    public Ingredient()
    {

    }

    [SetsRequiredMembers]
    public Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

