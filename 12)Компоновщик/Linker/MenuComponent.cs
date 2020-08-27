using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linker
{
    public abstract class MenuComponent
    {
        // Комбинацинные мнтоды (добавление, удаление, получение)
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new Exception();
        }

        // Группа методов операций, используемых MenuItem
        public string GetName()
        {
            throw new Exception();
        }
        public string GetDescription()
        {
            throw new Exception();
        }
        public string GetPrice()
        {
            throw new Exception();
        }
        public bool IsVegetarian()
        {
            throw new Exception();
        }
        public virtual void Print()
        {
            throw new Exception();
        }

        public abstract IEnumerator CreateIterator();
    }
}
