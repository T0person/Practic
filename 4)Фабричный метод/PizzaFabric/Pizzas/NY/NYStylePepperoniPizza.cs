using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Pizzas.NY
{
    public class NYStylePepperoniPizza : Pizza
    {

        public NYStylePepperoniPizza()
        {
            name = "Пепперони NY";
            dough = "Тесто для нее";
            sauce = "Соус для нее";

            toppings.Add("Добавка для нее");
        }
    }
}
