using System;

namespace Starbuzz
{
    public abstract class Drink
    {
        int _answer;
        // Шаблонный метод
        public void PrepareRecipe()
        {
            BoilWater();
            BrewDrink();
            PourInCup();
            if(CustomerWantsCondiments())
                AddCondiments();
        }
        public void BoilWater()
        {
            Console.WriteLine("Вода кипятится");
        }

        public abstract void BrewDrink();

        public void PourInCup()
        {
            Console.WriteLine($"{this} разливается по чашкам");
        }

        public abstract void AddCondiments();

        public bool CustomerWantsCondiments()
        {
            Console.Write("Хотите добавки в напиток?(0/1): ");
            _answer = Convert.ToInt32(Console.ReadLine());
            switch (_answer)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                default:
                    return false;
            }
        }
    }
}
