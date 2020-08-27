using PizzaFabric.Pizzas.NY;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFabric.Store
{
    class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {

            if (item.Equals("cheese"))
                return new NYStyleCheesePizza();
            else if (item.Equals("pepperoni"))
                return new NYStylePepperoniPizza();
            else if (item.Equals("clam"))
                return new NYStyleClamPizza();
            else if (item.Equals("veggie"))
                return new NYStyleVeggiePizza();
            else return null;
        }
    }
}
