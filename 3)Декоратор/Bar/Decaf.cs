using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Кофе без кофеина";
        }
        public override double cost()
        {
            return 1.05;
        }
    }
}
