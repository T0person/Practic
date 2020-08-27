using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class TheaterLights
    {
        public void Dim(int value)
        {
            Console.WriteLine($"{value} % яркости света");
        }

        public void On()
        {
            Console.WriteLine("Свет включается");
        }
    }
}
