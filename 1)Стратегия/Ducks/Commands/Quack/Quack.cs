using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Quack
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Кряк!!!");
        }
    }
}
