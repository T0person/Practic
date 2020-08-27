using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Чикагская пицца";
            dough = "Толсткое тесто";
            sauce = "Томатный соус";
            toppings.Add("Пепперони");
        }
    }
}
