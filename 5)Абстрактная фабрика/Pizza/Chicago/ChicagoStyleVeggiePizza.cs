using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Chicago
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Чикагская пицца";
            dough = "Толсткое тесто";
            sauce = "Томатный соус";
            toppings.Add("Вегетарианская");
        }
    }
}
