using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.NY
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "Нью-йоркская пицца";
            dough = "Тонкое тесто с корочкой";
            sauce = "Marinara Souce";

            toppings.Add("Вегетарианская");
        }
    }
}
