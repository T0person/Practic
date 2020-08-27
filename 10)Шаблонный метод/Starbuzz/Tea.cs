using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    class Tea : Drink
    {
        public override void BrewDrink()
        {
            Console.WriteLine("Чай настаивается в горячей воде");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Добаление лимона");
        }
    }
}
