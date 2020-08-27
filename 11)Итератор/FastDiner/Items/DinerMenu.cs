using FastDiner.Interfaces;
using System;
using System.Collections;

namespace FastDiner.Items
{
    class DinerMenu : Menu
    {
        static int MAX_ITEMS = 6;
        int _numberOfitems = 0;

        // Храним текущую позицию перебора в массиве
        public MenuItem[] menuItems;
        
        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Вегетарианский БЛТ", "Описание его", true, 2.99);
            AddItem("Бекон", "Описание его", false, 2.99);
            AddItem("Суп", "Описание его", false, 3.29);
            AddItem("Хот-Дог", "Описание его", false, 3.05);
            remove();
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfitems >= MAX_ITEMS)
                Console.WriteLine("Список полон!!!");
            else
            {
                menuItems[_numberOfitems] = menuItem;
                _numberOfitems++;
            }
        }
        public void remove()
        {
            if (_numberOfitems <= 0)
            {
                Console.WriteLine("Ошибочка!!!");
            }
            if (menuItems[_numberOfitems - 1] != null)
            {
                for (int i = _numberOfitems - 1; i < (menuItems.Length - 1); i++)
                {
                    menuItems[i] = menuItems[i + 1];
                }
                menuItems[menuItems.Length - 1] = null;
            }
        }
        public IEnumerator CreateIterator()
        {
            return menuItems.GetEnumerator();
            //return new DinerMenuIterator(menuItems);
        }
    }
}
