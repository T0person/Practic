using Pizza.Pizzas;
using System;

namespace Pizza
{
    // 4 глава
    // 5 паттерн
    // Абстрактная фабрика
    class Program
    {
        static void Main(string[] args)
        {

            //Создаем новый экземпляр
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            
            //Вызываю метод в экземпляре
            nyPizzaStore.orderPizza("clam");
        }
    }
}
