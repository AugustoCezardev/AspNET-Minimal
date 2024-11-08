using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Minimal.API.DbContexts;
using Minimal.API.Models.DTO;

namespace Minimal.API.EndpointHandlers;

public static class IngredientsHandler
{
    public static async Task<Results<NoContent, Ok<List<IngredientDto>>>> 
        GetFoodIngredientsAsync(AppDbContext dbContext, IMapper mapper, [FromRoute] int id)
    {
        var ingredients = mapper.Map<IEnumerable<IngredientDto>>((await dbContext.Foods
            .Include(x => x.Ingredients)
            .FirstOrDefaultAsync(x => x.Id == id))?.Ingredients);

        var ingredientList = ingredients.ToList();
        if (ingredientList.Count != 0)
            return TypedResults.Ok(ingredientList);

        return TypedResults.NoContent();
    }
}