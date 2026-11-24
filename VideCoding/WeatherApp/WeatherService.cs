using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp;

public class WeatherService {
    public async Task<string> GetWeatherAsync() {
        using HttpClient client = new();

        string url =
        "https://api.open-meteo.com/v1/forecast?latitude=35.68&longitude=139.76&current=temperature_2m,relative_humidity_2m,weather_code&daily=weather_code,temperature_2m_max,temperature_2m_min&timezone=Asia%2FTokyo\r\n";

        return await client.GetStringAsync(url);
    }
}