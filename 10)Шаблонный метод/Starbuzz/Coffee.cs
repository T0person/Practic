using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    class Coffee : Drink
    {
        public override void BrewDrink()
        {
            Console.WriteLine("Кофе настаивается в горячей воде");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Добаление сахара и молока в кофе");
        }
    }
}
