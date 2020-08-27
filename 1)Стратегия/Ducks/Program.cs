using Ducks.Commands.Fly;
using System;
using System.Runtime.CompilerServices;

namespace Ducks
{
    // 1 глава
    // Стратегия
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performQuack();
            mallard.performFly();
            Console.WriteLine("\n");

            Duck model = new ModelDuck();
            model.display();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
