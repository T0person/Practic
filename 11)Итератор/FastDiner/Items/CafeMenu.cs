using FastDiner.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Items
{
    public class CafeMenu : Menu
    {
        Hashtable menuItems = new Hashtable();
        ArrayList Items = new ArrayList();
        public CafeMenu()
        {
            AddItem("Вегетарианский бургер", "Его описание", true, 3.99);
            AddItem("Суп", "Его описание", false, 3.69);
            AddItem("Буррито", "Его описание", false, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.Name, menuItem);
        }

        public IEnumerator CreateIterator()
        {

            IDictionaryEnumerator dictionaryEnumerator = menuItems.GetEnumerator();
            while (dictionaryEnumerator.MoveNext())
            {
                DictionaryEntry dictionaryEntry = dictionaryEnumerator.Entry;
                MenuItem menuItem = (MenuItem)dictionaryEntry.Value;
                Items.Add(menuItem);
            }
            return Items.GetEnumerator();
        }
    }
}
