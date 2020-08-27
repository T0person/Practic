using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Pizzas.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Pepperoni Chicago";
            dough = "Тесто для нее";
            sauce = "Соус для нее";

            toppings.Add("Добавка для нее");
        }
    }
}
