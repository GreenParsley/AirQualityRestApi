using AirQualityAPI.Queries.Trips;
using AirQualityAPI.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirQualityAPI.Controllers;

public class TripsController : AirQualityControllerBase
{
    public readonly IQueryAsyncHandler<TripsResponse, TripsQuery> _tripsHandler;
    public readonly ILoggerMethod _loggerMethod;
    public TripsController(IQueryAsyncHandler<TripsResponse, TripsQuery> tripsHandler, ILoggerMethod loggerMethod)
    {
        _tripsHandler = tripsHandler ?? throw new ArgumentNullException(nameof(tripsHandler));
        _loggerMethod = loggerMethod ?? throw new ArgumentNullException(nameof(loggerMethod));
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<TripsResponse>> Get([FromQuery] TripsQuery dto, CancellationToken cancellationToken = default)
    {
        _loggerMethod.logEndpointCall(HttpMethod.Get, "api/trips");
        return Ok(await _tripsHandler.HandleAsync(dto, cancellationToken));
    }
}
