using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
