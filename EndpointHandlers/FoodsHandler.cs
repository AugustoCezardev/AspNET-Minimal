using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Minimal.API.DbContexts;
using Minimal.API.Entities;
using Minimal.API.Models.DTO;

namespace Minimal.API.EndpointHandlers;

public static class FoodsHandler
{
    public static async Task<Results<NoContent, Ok<List<FoodDto>>>> 
        GetFoodByNameAsync(AppDbContext dbContext, IMapper mapper, ILogger<FoodDto> logger, [FromQuery] string? name)
    {
        var foodsEntity = mapper.Map<IEnumerable<FoodDto>>(
            await dbContext.Foods.Where(x => name == null || x.Name.ToLower().Contains(name.ToLower())).ToListAsync());

        var foodsList = foodsEntity.ToList();
        if (foodsList.Count != 0)
        {
            logger.LogInformation($"Found {foodsList.Count} foods for name {name}");
            return TypedResults.Ok(foodsList);
        }
    
        logger.LogInformation($"No foods found with name {name}");   
        return TypedResults.NoContent();
    }
    
    public static async Task<Results<NoContent, Ok<FoodDto>>> 
        GetFoodByIdAsync(AppDbContext dbContext, IMapper mapper, [FromRoute] int id)
    {
        var foodEntity = mapper.Map<FoodDto>(await dbContext.Foods.FirstOrDefaultAsync(x => x.Id == id));
        
        if(foodEntity != null)
            return TypedResults.Ok(foodEntity);
        
        return TypedResults.NoContent();
    }
    
    public static async Task<CreatedAtRoute<FoodDto>> 
        CreateFoodAsync(AppDbContext dbContext, IMapper mapper, [FromBody] CreateFoodDto createFoodDto)
    {
        var food = mapper.Map<Food>(createFoodDto);
        dbContext.Foods.Add(food);
        await dbContext.SaveChangesAsync();
        var foodDto = mapper.Map<FoodDto>(food);

        return TypedResults.CreatedAtRoute(foodDto, "GetFood", new { id = food.Id });
    }
    
    public static async Task<Results<NoContent, Ok>> 
        UpdateFoodAsync(AppDbContext dbContext, IMapper mapper, [FromRoute] int id, [FromBody] UpdateFoodDto updateFoodDto)
    {
        var foodEntity = await dbContext.Foods.FirstOrDefaultAsync(x => x.Id == id);
        
        if(foodEntity == null)
            return TypedResults.NoContent();
        
        mapper.Map(updateFoodDto, foodEntity);
        await dbContext.SaveChangesAsync();
        
        return TypedResults.Ok();
    }
    
    public static async Task<Results<NoContent, Ok>>
    DeleteFoodAsync(AppDbContext dbContext, [FromRoute] int id)
    {
        var foodEntity = await dbContext.Foods.FirstOrDefaultAsync(x => x.Id == id);
        
        if(foodEntity == null)
            return TypedResults.NoContent();
        
        dbContext.Foods.Remove(foodEntity);
        await dbContext.SaveChangesAsync();
        
        return TypedResults.Ok();
    }
}