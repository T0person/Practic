using Pizza.Ingredients;
using Pizza.Ingredients.Chicago;
using Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Factories
{
    // Реализация фабрики ингридиентов для Чикаго
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
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
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = {new BlackOlives(), new Spinach(), new EggPlant()};
            return veggies;
        }
    }
}
