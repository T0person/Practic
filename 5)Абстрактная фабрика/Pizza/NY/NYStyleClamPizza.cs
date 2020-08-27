using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.NY
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "Нью-йоркская пицца";
            dough = "Тонкое тесто с корочкой";
            sauce = "Marinara Souce";

            toppings.Add("Из молюсков");
        }
    }
}
