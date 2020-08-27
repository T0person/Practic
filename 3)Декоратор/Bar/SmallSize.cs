using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class SmallSize : CondimentDecorator
    {
        Beverage beverage;
        public SmallSize(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description;
        }

        public override double cost()
        {
            return .1 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", SmallSize";
        }
    }
}
