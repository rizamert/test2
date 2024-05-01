using Microsoft.AspNetCore.Mvc;
using Remx.Application.Base.Result;

namespace Remx.Api.Extensions;

public static class HttpResponseExtensions
{
    public static IActionResult ToActionResult(this Result response)
    {
        return response.IsSuccess ? new OkObjectResult(response) : new BadRequestObjectResult(response);
    }

}