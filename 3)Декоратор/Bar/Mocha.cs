using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    class Mocha : CondimentDecorator
    {
        // Переменная для хранения ссылки
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            // Передаем ссылку при вызове конструктора
            this.beverage = beverage;
            description = beverage.description;
        }

        public override double cost()
        {
            return .20 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Шоколад";
        }
    }
}
