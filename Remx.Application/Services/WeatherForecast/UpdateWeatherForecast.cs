using Remx.Application.Base.Result;
using Remx.Application.Base.Service;
using Remx.Domain.UnitOfWork;

namespace Remx.Application.Services;

public class UpdateWeatherForecast : IBusinessService<UpdateWeatherForecast.Request, UpdateWeatherForecast.Response>
{
    #region constructor

    public UpdateWeatherForecast()
    {
    }

    #endregion

    #region Request & Response

    public class Request
    {
    }

    public class Response
    {
    }

    #endregion

    public async Task<Result<Response>> ExecuteAsync(Request request)
    {
        //TODO write business code here
        return null;
    }
}