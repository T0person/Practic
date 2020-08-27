using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description;
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Взбитые сливки";
        }
    }
}
