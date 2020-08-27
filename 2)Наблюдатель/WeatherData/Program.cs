using System;

namespace WeatherData
{
    class Program
    {
        // 2 глава
        // 2 паттерн
        // Наблюдатель
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            CurrentConditionsDisplay currentDisplay1 = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
