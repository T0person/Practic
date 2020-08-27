using PizzaFabric.Store;
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace PizzaFabric
{
    // 4 глава
    // 4 паттерн
    // Фабричный метод
    class Program
    {

        // Это фабричный метод!!!
        // Создает наследование
        // Здесь нужно расширять класс и переопределять фабричный методы (методы), который создает объекты
        // Вся суть этого паттерна заключается в использовании субкласса, который за нас создает объекты.
        // Клиенты достаточно знать абстрактный тип, который они используют, а суб класс имеет дело с различными конкретными типами!
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore ChicagoPizzaStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("cheese");

            pizza = ChicagoPizzaStore.OrderPizza("clam");
        }
    }
}
