using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Interfaces
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
