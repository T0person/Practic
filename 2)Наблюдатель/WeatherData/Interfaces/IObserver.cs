using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData.Interfaces
{
    interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
