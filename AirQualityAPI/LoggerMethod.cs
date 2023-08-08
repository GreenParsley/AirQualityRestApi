namespace AirQualityAPI;

public class LoggerMethod : ILoggerMethod
{
    private readonly ILogger<LoggerMethod> _logger;

    public LoggerMethod(ILogger<LoggerMethod> logger)
    {
        _logger = logger;
    }
    public void logEndpointCall(HttpMethod method, string path)
    {
        _logger.LogInformation($"{method.Method} {path}");
    }
}
