using Pizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}
