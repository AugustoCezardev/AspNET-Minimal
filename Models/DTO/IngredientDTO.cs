namespace Minimal.API.Models.DTO;

public class IngredientDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    
    public int FoodId { get; set; }
}