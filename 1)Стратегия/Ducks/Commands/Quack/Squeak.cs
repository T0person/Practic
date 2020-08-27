using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Quack
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Писк");
        }
    }
}
