using Microsoft.AspNetCore.Mvc;

namespace Minimal.API.EndpointFilters;

public class ImutableFoodFilter(int blokedFoodId) : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var foodId = Convert.ToInt32(context.HttpContext.Request.Query["id"].FirstOrDefault());

        if (foodId == blokedFoodId)
        {
            return TypedResults.Problem(
                new ProblemDetails
                {
                    Status = 400,
                    Title = "Forbidden",
                    Detail = "The requested food ID is invalid.",
                        
                });
        }

        var result = await next.Invoke(context);
        return result;
    }
}