using Microsoft.AspNetCore.Mvc;

namespace AirQualityAPI.Controllers;

[ApiController]
[Route(Microservice + "/[controller]")]
public class AirQualityControllerBase : Controller
{
    private const string Microservice = "Api";
}
