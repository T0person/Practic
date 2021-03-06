﻿using Pizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza.Pizzas
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory IngredientFactory;

        //В конструктор передается объект фабрики, от куда будет поставляться ингредиенты
        public ClamPizza(IPizzaIngredientFactory IngredientFactory)
        {
            this.IngredientFactory = IngredientFactory;
        }

        //Метод готовит пиццу с сыром. Когда ему нужны игредиенты, он запрашиват у фабрики
        public override void Prepare()
        {
            Console.WriteLine($"Подготовка {name}");
            dough = IngredientFactory.CreateDough();
            sauce = IngredientFactory.CreateSauce();
            cheese = IngredientFactory.CreateCheese();

            //Если будет Нбюй-Йоркская фабрика, мидии свежие, если чикагская - мороженные
            clam = IngredientFactory.CreateClam();
        }
    }
}
