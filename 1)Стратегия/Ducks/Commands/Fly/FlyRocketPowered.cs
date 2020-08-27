using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Fly
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Реактивный полет!!!");
        }
    }
}
