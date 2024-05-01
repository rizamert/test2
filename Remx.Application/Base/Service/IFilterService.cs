using Remx.Application.Base.Result;

namespace Remx.Application.Base.Service;


public interface IFilterService<TRequest, TResponse>
{
    Task<FilterResult<TResponse>> ExecuteAsync(TRequest request);
}