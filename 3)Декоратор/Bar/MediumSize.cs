using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class MediumSize : CondimentDecorator
    {
        Beverage beverage;
        public MediumSize(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description;
        }
        public override double cost()
        {
            return .15 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", MediumSize";
        }
    }
}
