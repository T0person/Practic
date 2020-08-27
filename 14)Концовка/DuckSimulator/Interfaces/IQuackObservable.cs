using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Interfaces
{
    // Для паттерна НАБЛЮДАТЕЛЬ
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
