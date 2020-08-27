using Ducks.Commands.Fly;
using Ducks.Commands.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("Я утка - приманка");
        }
    }
}
