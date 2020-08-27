using Ducks2.Adapters;
using Ducks2.Duck;
using Ducks2.Interfaces;
using Ducks2.Turkeys;
using System;

namespace Ducks2
{
    // 7 глава
    // 8 паттерн
    // Адаптер
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("\t---Turkey!!!---");
            turkey.Fly();
            turkey.Gobble();
            // Ошибка так как Turkey реализует интерфейс ITurkey
            //TestDuck(turkey);
            TestDuck(turkeyAdapter);

            Console.WriteLine("\n\t---Duck!!!---");
            duck.Fly();
            duck.Quack();

            Console.WriteLine("\t---Turkey!!!---");
            TestDuck(turkeyAdapter);

            Console.WriteLine("\n\t---Duck!!!---");
            TestDuck(duck);

            Console.WriteLine("\n\t---Duck!!!---");
            ITurkey duckAdapter = new DuckAdapter(duck);

            duckAdapter.Fly();
            duckAdapter.Gobble();
        }

        static private void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
