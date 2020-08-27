using Pizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace Pizza
{

    // Это абстрактная фабрика она использует композицию!
    // Она используется для создания семейств продуктов.
    // Субклассы этого типа определяют способ создания продуктов
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        Veggies[] veggies;
        public Cheese cheese;
        Pepperoni pepperoni;
        public Clams clam;
        // Здесь собираются ингридиенты, которые собираются в фабриках ингридиентов
        abstract public void Prepare();

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
