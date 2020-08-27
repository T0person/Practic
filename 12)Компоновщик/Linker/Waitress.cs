using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linker
{
    public class Waitress
    {
        // Самый верхний компонент
        private MenuComponent _allMenus;

        public Waitress(MenuComponent _allMenus)
        {
            this._allMenus = _allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = _allMenus.CreateIterator();
            Console.WriteLine("Vegetarian menu");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                        menuComponent.Print();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
        }
    }
}
