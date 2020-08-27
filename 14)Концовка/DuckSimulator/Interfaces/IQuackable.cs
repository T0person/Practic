using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Interfaces
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
