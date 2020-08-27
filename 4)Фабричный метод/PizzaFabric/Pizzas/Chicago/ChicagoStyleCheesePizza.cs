using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Pizzas.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {

        public ChicagoStyleCheesePizza()
        {
            name = "Cheese Chicago";
            dough = "Тесто для нее";
            sauce = "Соус для нее";

            toppings.Add("Добавка для нее");
        }
    }
}
