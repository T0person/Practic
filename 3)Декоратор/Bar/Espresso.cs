using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Эспрессо";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
