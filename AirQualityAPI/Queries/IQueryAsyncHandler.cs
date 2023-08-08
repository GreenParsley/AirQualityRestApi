namespace AirQualityAPI.Queries;

public interface IQueryAsyncHandler<TResult, TRequest> where TRequest : class where TResult : class
{
    public Task<TResult> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}
