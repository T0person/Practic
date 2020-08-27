using FastDiner.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
