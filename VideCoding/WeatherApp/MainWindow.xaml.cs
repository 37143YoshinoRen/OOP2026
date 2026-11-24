using System.Text.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherApp;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private async void SearchButton_Click(
    object sender,
    RoutedEventArgs e)
{
    WeatherService service = new();

    string json = await service.GetWeatherAsync();

    WeatherData? data =
        JsonSerializer.Deserialize<WeatherData>(json);

    WeatherTextBlock.Text =
        $"天気：{GetWeatherDescription(data?.current?.weather_code ?? -1)}";

    TempTextBlock.Text =
        $"気温：{data?.current?.temperature_2m} ℃";

    HumidityTextBlock.Text =
        $"湿度：{data?.current?.relative_humidity_2m} %";



    ForecastList.Items.Clear();

    ForecastList.Items.Add("水 18℃");
    ForecastList.Items.Add("木 20℃");
    ForecastList.Items.Add("金 16℃");
    ForecastList.Items.Add("土 19℃");
    ForecastList.Items.Add("日 21℃");
    ForecastList.Items.Add("月 17℃");
    ForecastList.Items.Add("火 18℃");
}

    private string GetWeatherDescription(int code) {
        return code switch {
            0 => "快晴",
            1 => "晴れ",
            2 => "一部曇り",
            3 => "曇り",
            45 => "霧",
            51 => "小雨",
            61 => "雨",
            71 => "雪",
            95 => "雷雨",
            _ => "不明"
        };
    }
}