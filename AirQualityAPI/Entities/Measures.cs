using System.ComponentModel.DataAnnotations;

namespace AirQualityAPI.Entities;

public class Measures
{
    public int Id { get; set; }
    public int Timestamp { get; set; }
    public DateTime Date { get; set; }
    public int NO2 { get; set; }
    public int VOC { get; set; }
    public float PM10 { get; set; }
    public float PM2 { get; set; }
    public int PM1 { get; set; }
    public int NO2_PlumeAQI { get; set; }
    public int VOC_PlumeAQI { get; set; }
    public float PM10_PlumeAQI { get; set; }
    public float PM2_PlumeAQI { get; set; }
    public int PM1_PlumeAQI { get; set; }
    public int TripId { get; set; }
    public virtual Trips Trip { get; set; } = null!;
}
