using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks.Commands.Quack
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Тишина! >>");
        }
    }
}
