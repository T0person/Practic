using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Усилитель звука включается");
        }

        public void SetDvd(DvdPlayer _dvd)
        {
            Console.WriteLine($"Усилитель звука: Включается звук {_dvd}");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Усилитель звука: Включается объемный звук");
        }

        public void SetVolume(int _value)
        {
            Console.WriteLine($"Усилитель звука: Включается громкость звука {_value}");
        }
        public void Off()
        {
            Console.WriteLine("Усилитель звука выключается");
        }
    }
}
