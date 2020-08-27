using System;
using System.Collections.Generic;
using System.Text;
using WeatherData.Interfaces;

namespace WeatherData
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject WeatherData)
        {
            this.WeatherData = WeatherData;
            WeatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Уловия: {temperature} температура и {humidity} процентов влажности");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}
