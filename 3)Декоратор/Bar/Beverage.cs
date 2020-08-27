using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public abstract class Beverage
    {
        public string description = "Неизвестный напиток";

        public string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
