using Ducks2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks2.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
