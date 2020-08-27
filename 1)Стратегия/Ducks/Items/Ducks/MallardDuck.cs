using Ducks.Commands.Fly;
using Ducks.Commands.Quack;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("Я MallardDuck");
        }
    }
}
