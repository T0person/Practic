using Ducks2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks2.Adapters
{
    public class DuckAdapter : ITurkey
    {
        IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
        }
        public void Fly()
        {
            duck.Fly();
        }

        public void Gobble()
        {
            duck.Quack();
        }
    }
}
