using AutoMapper;
using Minimal.API.Entities;
using Minimal.API.Models.DTO;

namespace Minimal.API.Mapping;

public class MappingConfig: Profile
{
    public MappingConfig()
    {
        CreateMap<Food, FoodDto>().ReverseMap();
        CreateMap<Ingredient, IngredientDto>()
            .ForMember(i => i.FoodId,
                opt => opt.MapFrom(src => src.Foods.First().Id));
        CreateMap<Food, CreateFoodDto>().ReverseMap();
        CreateMap<Food, UpdateFoodDto>().ReverseMap();
    }
}