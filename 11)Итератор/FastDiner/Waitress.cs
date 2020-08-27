using FastDiner.Interfaces;
using System;
using System.Collections;

namespace FastDiner
{
    class Waitress
    {
        ArrayList menus;

        public Waitress(ArrayList menus)
        {
            this.menus = menus;
        }
        public void PrintMenu()
        {
            IEnumerator menuIterator = menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                Menu menu = (Menu)menuIterator.Current;
                PrintMenu(menu.CreateIterator());
            }
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                if(menuItem != null)
                    Console.WriteLine($"{menuItem.Name} {menuItem.Description} {menuItem.Vegetarian} {menuItem.Price}");
            }
            Console.WriteLine("\n");
        }
    }
}
