using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class DvdPlayer
    {

        public void On()
        {
            Console.WriteLine("DVD: Включается");
        }

        public void Off()
        {
            Console.WriteLine("DVD: Выключается");
        }

        public void Play(string _movie)
        {
            Console.WriteLine($"DVD: Включается фильм: \"{_movie}\"");
        }
        public void Stop()
        {
            Console.WriteLine($"DVD: Остановка фильма");
        }

        public void Eject()
        {
            Console.WriteLine($"DVD: достать диск");
        }
    }
}
