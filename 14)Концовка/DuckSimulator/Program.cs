using DuckSimulator.Adapters;
using DuckSimulator.Decorators;
using DuckSimulator.Factory;
using DuckSimulator.Factory.Geese;
using DuckSimulator.Flocks;
using DuckSimulator.Interfaces;
using DuckSimulator.Objects;
using DuckSimulator.Objects.Ducks;
using System;

namespace DuckSimulator
{
    // 12 глава
    // 14 паттерн
    // Патерн ПАТТЕРНОВ
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new CountingGooseFactory();

            program.Simulate(duckFactory, gooseFactory);
        }

        private void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            //IQuackable _mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable _redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable _duckCall = duckFactory.CreateDuckCall();
            IQuackable _rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable _gooseDuck = gooseFactory.CreateGoose();

            Flock flockOfDucks = new Flock();

            //flockOfDucks.Add(_mallardDuck);
            flockOfDucks.Add(_redheadDuck);
            flockOfDucks.Add(_duckCall);
            flockOfDucks.Add(_rubberDuck);
            flockOfDucks.Add(_gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();
            //IQuackable mallardFive = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);
            //flockOfMallards.Add(mallardFive);

            flockOfDucks.Add(flockOfMallards);
            

            Console.WriteLine("Duck Simulator\nFull Flock");

            Simulate(flockOfDucks);

            Console.WriteLine("Duck Simulator\nMallard Flock");

            Simulate(flockOfMallards);

            Console.WriteLine("Value:" + QuackCounter.NumberOfQuacks);

            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);
            Console.WriteLine("Утки крякнут " + QuackCounter.NumberOfQuacks + " раз");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
