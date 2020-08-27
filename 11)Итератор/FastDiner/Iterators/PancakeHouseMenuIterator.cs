using FastDiner.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        public ArrayList items;
        int position = 0;
        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }
        public bool hasNext()
        {
            if (position >= items.Count || items[position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItem menuItem = (MenuItem)items[position];
            position++;
            return menuItem;
        }
    }
}
