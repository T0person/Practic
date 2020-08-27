using Pizza.Factories;
using Pizza.Interfaces;
using Pizza.Pizzas;

namespace Pizza
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            Pizza pizza = null;

            // Фабрика производит ингредиенты для всех пицц в Чикаго стиле
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "Чикагская с сыром";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.name = "Чикагская Вегетарианская";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.name = "Чикагская с мидиями";
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.name = "Чикагская Пепперони";
            }
            return pizza;
        }
    }
}
