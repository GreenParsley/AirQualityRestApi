namespace AirQualityAPI;

public interface ILoggerMethod
{
    void logEndpointCall(HttpMethod method, string path);
}
