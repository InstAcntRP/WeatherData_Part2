using WeatherData.Services;

namespace WeatherData.Batch;

public class Application
{
    private readonly IWeatherDataService _weatherDataService;

    public Application(IWeatherDataService weatherDataService)
    {
        _weatherDataService= weatherDataService;
    }
    public void Run()
    {
        Console.WriteLine("Run method is invoked");
        var  task = Task.Run(async()=> await _weatherDataService.GetWeatherDataViaAPI()).Result;
    }
}