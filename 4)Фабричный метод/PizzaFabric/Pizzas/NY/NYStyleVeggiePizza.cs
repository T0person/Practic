using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Pizzas.NY
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "Вегетарианская NY";
            dough = "Тесто для нее";
            sauce = "Соус для нее";

            toppings.Add("Добавка для нее");
        }
    }
}
