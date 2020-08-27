using FastDiner.Interfaces;
using System.Collections;

namespace FastDiner.Items
{
    class PancakeHouseMenu : Menu
    {
        public ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("1 блюдо блинной", "на яйцах и т.д.", true, 2.99);
            AddItem("2 блюдо блинной", "на яйцах и т.д.", true, 2.99);
            AddItem("3 блюдо блинной", "на яйцах и т.д.", true, 3.49);
            AddItem("3 блюдо блинной (вафли)", "на яйцах и т.д.", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public IEnumerator CreateIterator()
        {
            return menuItems.GetEnumerator();
            //return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
