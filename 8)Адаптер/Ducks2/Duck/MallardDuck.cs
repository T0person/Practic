using Ducks2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks2.Duck
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Я лечу!");
        }

        public void Quack()
        {
            Console.WriteLine("Квак");
        }
    }
}
