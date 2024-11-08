using System.Net;

namespace Minimal.API.EndpointFilters;

public class LogNotFoundFilter(ILogger<LogNotFoundFilter> logger): IEndpointFilter
{
    private readonly ILogger<LogNotFoundFilter> _logger = logger;

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var result = await next(context);
        var httpResult = (result is INestedHttpResult result1) ? result1.Result : (IResult)result!;

        if (httpResult is IStatusCodeHttpResult { StatusCode: (int)HttpStatusCode.NotFound })
        {
            _logger.LogInformation($"Resource {context.HttpContext.Request.Path} returned 404");
        }
        
        return result;
    }
}