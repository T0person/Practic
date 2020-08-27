using DuckSimulator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    // Реализация для наблюдения(оповещение)!
    public class Observable : IQuackObservable
    {
        ArrayList observers = new ArrayList();
        IQuackObservable duck;
        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }
        public void NotifyObservers()
        {
            IEnumerator iterator = observers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IObserver observer = (IObserver)iterator.Current;
                observer.Update(duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
