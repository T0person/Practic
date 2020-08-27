using Pizza.Ingredients;
using Pizza.Ingredients.NY;
using Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Factories
{
    // Реализация фабрики ингридиентов для Нью-Йорка
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = {new Garlic(),new Onion(), new Mushroom(), new RedPepper()};
            return veggies;
        }
    }
}
