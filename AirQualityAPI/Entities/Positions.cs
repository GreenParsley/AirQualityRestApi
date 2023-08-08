namespace AirQualityAPI.Entities;

public class Positions
{
    public int Id { get; set; }
    public int Timestamp { get; set; }
    public DateTime Date { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public int TripId { get; set; }
    public virtual Trips Trip { get; set; } = null!;
}
