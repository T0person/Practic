using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Чикагская пицца";
            dough = "Толсткое тесто";
            sauce = "Томатный соус";
            toppings.Add("Сыр моцарелла");
        }

        public override void Cut()
        {
            Console.WriteLine("Нарезаем пиццу квадратиками");
        }

    }
}
