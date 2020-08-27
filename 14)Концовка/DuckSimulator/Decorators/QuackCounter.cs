using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Decorators
{
    class QuackCounter : IQuackable
    {
        IQuackable duck;
        public static int NumberOfQuacks { get; set; }
        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }
    }
}
