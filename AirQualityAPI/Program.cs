using AirQualityAPI;
using AirQualityAPI.Entities;
using AirQualityAPI.Entities.Repositories;
using AirQualityAPI.Queries;
using AirQualityAPI.Queries.Trips;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var service = builder.Services;
// Add services to the container.

service.AddDbContext<AirQualityDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("AirQualityDbConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

service.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
service.AddEndpointsApiExplorer();


service.AddScoped<ILoggerMethod, LoggerMethod>();

service.AddScoped<ITripsRepository, TripsRepository>();
service.AddScoped<IQueryAsyncHandler<TripsResponse, TripsQuery>, TripsHandler>();

service.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
