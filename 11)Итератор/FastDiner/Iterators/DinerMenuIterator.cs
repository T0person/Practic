using FastDiner.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] _items;
        private int _position = 0;
        public DinerMenuIterator(MenuItem[] _items)
        {
            this._items = _items;
        }
        public bool hasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }

        public void remove()
        {
            if(_position <= 0)
            {
                Console.WriteLine("Ошибочка!!!");
            }
            if(_items[_position - 1] != null)
            {
                for (int i = _position - 1; i < (_items.Length-1); i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[_items.Length - 1] = null;
            }
        }
    }
}
