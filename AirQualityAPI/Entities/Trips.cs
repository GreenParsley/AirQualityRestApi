namespace AirQualityAPI.Entities;

public class Trips
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string TripType { get; set; } = string.Empty;
    public string Speed { get; set; } = string.Empty;
    public string Distance { get; set; } = string.Empty;
    public virtual List<Measures> Measures { get; set; } = null!;
    public virtual List<Positions> Positions { get; set; } = null!;

}
