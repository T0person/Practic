using Ducks2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks2.Turkeys
{
    class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Я летаю на короткие дистанции");
        }

        public void Gobble()
        {
            Console.WriteLine("Гугугу");
        }
    }
}
