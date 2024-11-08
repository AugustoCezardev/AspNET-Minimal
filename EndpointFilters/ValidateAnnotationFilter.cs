using System.Text.Json;
using Minimal.API.Models.DTO;
using MiniValidation;

namespace Minimal.API.EndpointFilters;

public class ValidateAnnotationFilter: IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var createFoodDto = context.GetArgument<CreateFoodDto>(2);

        if (!MiniValidator.TryValidate(createFoodDto, out var errors))
        {
            return TypedResults.ValidationProblem(errors);
        }
        
        return await next(context);
    }
}