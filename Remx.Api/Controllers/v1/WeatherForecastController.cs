using Microsoft.AspNetCore.Mvc;
using Remx.Application.Base;
using Remx.Application.Base.Service;
using Remx.Application.Dtos;
using Remx.Application.Responses;
using Remx.Application.Services;
using Remx.Application.Services.WeatherForecast;

namespace Remx.Api.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class WeatherForecastController : BaseController
{

    #region constructor

    private readonly BaseBusinessService _baseService;


    public WeatherForecastController(BaseBusinessService baseService)
    {
        _baseService = baseService;
    }

    #endregion

    [HttpGet("GetWeatherForecast")]
    public async Task<IActionResult> GetWeatherForecast(RequestPagination _)
    {
        var response = await _baseService.InvokeAsync<GetWeatherForecast,
            GetWeatherForecast.Request, GetWeatherForecast.Response>(new());
        
        if (!response.IsSuccess)
            return BadRequest(response);
        
        return Ok(response);
    }
    
    [HttpGet("GetWeatherForecastForCustomResponse")]
    public async Task<IActionResult> GetWeatherForecastForCustomResponse()
    {
        var response = await _baseService.InvokeDynamicAsync<GetWeatherForecastForCustomResponse,
            GetWeatherForecastForCustomResponse.Request, PagedTableResponse<WeatherForecastDto>>(new ());
        
        if (!response.IsSuccess)
            return BadRequest(response);
        
        return Ok(response);
    }
}