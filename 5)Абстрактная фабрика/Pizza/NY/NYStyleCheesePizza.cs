﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.NY
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "Нью-йоркская пицца";
            dough = "Тонкое тесто с корочкой";
            sauce = "Marinara Souce";

            toppings.Add("Тертый сыр Реджано");
        }
    }
}
