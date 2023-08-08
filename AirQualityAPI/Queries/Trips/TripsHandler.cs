namespace AirQualityAPI.Queries.Trips;

public class TripsHandler : IQueryAsyncHandler<TripsResponse, TripsQuery>
{
    public TripsHandler()
    {
    }

    public Task<TripsResponse> HandleAsync(TripsQuery request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

public class TripsQuery
{
    public int Id { get; set; }
}

public class TripsResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string TripType { get; set; } = string.Empty;
    public string Speed { get; set; } = string.Empty;
    public string Distance { get; set; } = string.Empty;
}
