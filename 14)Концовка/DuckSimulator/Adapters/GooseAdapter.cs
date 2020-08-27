using DuckSimulator.Interfaces;
using DuckSimulator.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Adapters
{
    class GooseAdapter : IQuackable
    {
        private Goose goose { get; }
        Observable observable;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }
        public void Quack()
        {
            goose.Honk();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }
    }
}
