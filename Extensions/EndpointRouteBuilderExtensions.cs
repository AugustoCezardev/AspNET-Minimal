using Minimal.API.EndpointFilters;
using Minimal.API.EndpointHandlers;

namespace Minimal.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void RegisterFoodsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var foodsEndpoint = endpointRouteBuilder.MapGroup("foods/").RequireAuthorization("Admin");

        foodsEndpoint.MapGet("", FoodsHandler.GetFoodByNameAsync)
            .WithOpenApi(ops => {
                ops.Deprecated = true;
                return ops;
            });
        foodsEndpoint.MapGet("{id:int}", FoodsHandler.GetFoodByIdAsync).WithName("GetFood");
        foodsEndpoint.MapPost("", FoodsHandler.CreateFoodAsync)
            .AddEndpointFilter<ValidateAnnotationFilter>();
        foodsEndpoint.MapPut("{id:int}",FoodsHandler.UpdateFoodAsync)
            .AddEndpointFilter(new ImutableFoodFilter(1))
            .AddEndpointFilter(new ImutableFoodFilter(2));
        foodsEndpoint.MapDelete("{id:int}", FoodsHandler.DeleteFoodAsync)
            .AddEndpointFilter<LogNotFoundFilter>();
    }

    public static void RegisterIngredientsEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapGet("foods/{id:int}/ingredients", IngredientsHandler.GetFoodIngredientsAsync)
            .RequireAuthorization();
    }
}