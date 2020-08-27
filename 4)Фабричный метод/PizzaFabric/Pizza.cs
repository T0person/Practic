using PizzaFabric.Pizzas.NY;
using System;
using System.Collections.Generic;

namespace PizzaFabric
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();
        // Здесь собираются ингридиенты, которые собираются в фабриках ингридиентов
        public void Prepare()
        {
            Console.WriteLine($"Готовится {name}");
            Console.WriteLine("Делается тесто");
            Console.WriteLine("Делается соус");
            Console.WriteLine("Добавляются добавки");
            foreach (var item in toppings)
            {
                Console.WriteLine(item);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Выпекается 25 минут при 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Пиццу разрезают");
        }

        public void Box()
        {
            Console.WriteLine("Пицца упаковывается в коробку");
        }
    }
}
