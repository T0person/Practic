using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class BigSize : CondimentDecorator
    {
        Beverage beverage;
        public BigSize(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description;
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", BigSize";
        }
    }
}
