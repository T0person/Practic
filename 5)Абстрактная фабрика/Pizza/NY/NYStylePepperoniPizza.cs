using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.NY
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "Нью-йоркская пицца";
            dough = "Тонкое тесто с корочкой";
            sauce = "Marinara Souce";

            toppings.Add("Пепперони");
        }
    }
}
