using DuckSimulator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Flocks
{
    // Стая
    class Flock : IQuackable
    {
        ArrayList quackers = new ArrayList();
        public void Add (IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void NotifyObservers() {}

        public void Quack()
        {
            IEnumerator iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quackable = (IQuackable)iterator.Current;
                quackable.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            IEnumerator iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable duck = (IQuackable)iterator.Current;
                duck.RegisterObserver(observer);
            }
        }
    }
}
