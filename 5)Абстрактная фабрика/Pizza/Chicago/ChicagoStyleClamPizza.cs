using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Chicago
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Чикагская пицца";
            dough = "Толсткое тесто";
            sauce = "Томатный соус";
            toppings.Add("Clam короче");
        }
    }
}
