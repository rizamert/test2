namespace Remx.Application.Base.Service;

public interface IDynamicResultService<TRequest, TResponse>
{
    Task<TResponse> ExecuteAsync(TRequest request);
}