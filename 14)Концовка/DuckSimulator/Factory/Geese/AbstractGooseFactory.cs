using DuckSimulator.Interfaces;
using DuckSimulator.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Factory.Geese
{
    public abstract class AbstractGooseFactory
    {
        public abstract IQuackable CreateGoose();
    }
}
