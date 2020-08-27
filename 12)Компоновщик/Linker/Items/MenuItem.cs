using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linker.Items
{
    // Класс листового узла (подменю)
    public class MenuItem : MenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }

        public MenuItem(string Name, string Description, bool Vegetarian, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Vegetarian = Vegetarian;
            this.Price = Price;
        }

        public override void Print()
        {
            if (Vegetarian)
                Console.WriteLine($"{Name}, {Description}, {Vegetarian}, {Price}");
            else
                Console.WriteLine($"{Name}, {Vegetarian}, {Price}");
        }

        public override IEnumerator CreateIterator()
        {
            return null;
        }
    }
}
