using DuckSimulator.Adapters;
using DuckSimulator.Interfaces;
using DuckSimulator.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Factory.Geese
{
    class CountingGooseFactory : AbstractGooseFactory
    {
        public override IQuackable CreateGoose()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
