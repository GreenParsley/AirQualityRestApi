using AirQualityAPI.Queries.Trips;
using Microsoft.EntityFrameworkCore;

namespace AirQualityAPI.Entities.Repositories;

public interface ITripsRepository
{
    Task<Trips> Get(TripsQuery query, CancellationToken cancellationToken = default);
}

public class TripsRepository : ITripsRepository
{
    private AirQualityDbContext _context { get; }

    public TripsRepository(AirQualityDbContext context)
    {
        _context = context;
    }

    public async Task<Trips> Get(TripsQuery query, CancellationToken cancellationToken = default) => await _context.Trips.Where(x => x.Id == query.Id).SingleAsync(cancellationToken);
}
