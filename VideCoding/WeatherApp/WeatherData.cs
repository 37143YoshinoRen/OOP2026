namespace WeatherApp;

public class WeatherData {
    public Current? current { get; set; }
}

public class Current {
    public double temperature_2m { get; set; }

    public int weather_code { get; set; }

    public int relative_humidity_2m { get; set; }
}