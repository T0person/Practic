using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Fly
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Не умею летать!!!");
        }
    }
}
