using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Pizzas.NY
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "Сырная NY";
            dough = "Тесто для нее";
            sauce = "Соус для нее";

            toppings.Add("Добавка для нее");
        }
    }
}
