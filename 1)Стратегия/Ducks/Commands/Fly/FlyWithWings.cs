using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Fly
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Я лечу!!!");
        }
    }
}
