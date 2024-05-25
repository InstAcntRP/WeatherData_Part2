namespace WeatherData.Services;

public interface IWeatherDataService
{
    Task<int> GetWeatherDataViaAPI();
}
