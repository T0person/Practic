using Pizza.Factories;
using Pizza.Interfaces;
using Pizza.Pizzas;

namespace Pizza
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            Pizza pizza = null;

            // Фабрика производит ингредиенты для всех пицц в Нью-Йоркском стиле
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "Нью-Йоркская с сыром";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.name = "Нью-Йоркская Вегетарианская";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.name = "Нью-Йоркская с мидиями";
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.name = "Нью-Йоркская Пепперони";
            }
            return pizza;
        }
    }
}
